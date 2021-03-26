package id.lksjateng.lks2021.kab_batang.util;

import android.content.SharedPreferences;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.nio.charset.StandardCharsets;
import java.util.concurrent.CompletableFuture;
import java.util.concurrent.ExecutionException;

import static id.lksjateng.lks2021.kab_batang.util.Async.async;

public class Request {

    public static final String BASE_URL = "http://10.0.2.2:5000/api/";

    private static SharedPreferences secret;

    private static long lastAuth = 0;
    private static String auth = null;

    public static String getAuth() {
        long now = System.currentTimeMillis();
        if ((now - lastAuth) > 600000) {
            try {
                Response res = post("Auth", "text/plain", "application/json", "{" +
                    "\"email\":\"" + secret.getString("email", "") + "\"," +
                    "\"password\":\"" + secret.getString("password", "") + "\"" +
                    "}", true)
                    .get();
                if (res.code < 400) {
                    lastAuth = now;
                    auth = res.asString();
                } else {
                    auth = null;
                }
            } catch (ExecutionException | InterruptedException e) {
                e.printStackTrace();
                auth = null;
            }
        }
        return auth;
    }

    public static void setSecret(SharedPreferences secret) {
        Request.secret = secret;
    }

    public static SharedPreferences getSecret() {
        return secret;
    }

    public static boolean hasSecret() {
        return secret.contains("email") && secret.contains("password");
    }

    public static void clearSecret() {
        SharedPreferences.Editor editor = secret.edit();
        editor.clear();
        editor.apply();
        lastAuth = 0;
        auth = null;
    }

    public static CompletableFuture<Response> post(String path, String accept, String contentType, String body, boolean skipAuth) {
        return async(() -> {
            try {
                URL url = new URL(BASE_URL + path);
                HttpURLConnection con = (HttpURLConnection) url.openConnection();
                con.setDoOutput(true);
                con.setRequestMethod("POST");
                con.setRequestProperty("accept", accept);
                con.setRequestProperty("Content-Type", contentType);

                if (!skipAuth) {
                    con.setRequestProperty("Authorization", "Bearer " + getAuth());
                }

                OutputStream out = con.getOutputStream();
                out.write(body.getBytes(StandardCharsets.UTF_8));

                con.connect();

                return new Response(con.getResponseCode(), con.getInputStream());
            } catch (IOException e) {
                e.printStackTrace();
                return new Response(500, null);
            }
        });
    }

    public static CompletableFuture<Response> get(String path, String accept, boolean skipAuth) {
        return async(() -> {
            try {
                URL url = new URL(BASE_URL + path);
                HttpURLConnection con = (HttpURLConnection) url.openConnection();
                con.setRequestMethod("GET");
                con.setRequestProperty("accept", accept);

                if (!skipAuth) {
                    con.setRequestProperty("Authorization", "Bearer " + getAuth());
                }

                con.connect();
                return new Response(con.getResponseCode(), con.getInputStream());
            } catch (IOException e) {
                e.printStackTrace();
                return new Response(500, null);
            }
        });
    }

    public static class Response {

        public final int code;
        public final BufferedReader reader;

        Response(int code, InputStream stream) {
            this.code = code;

            this.reader = stream == null? null : new BufferedReader(new InputStreamReader(stream));
        }

        public String asString() {
            try {
                StringBuilder builder = new StringBuilder();
                String line;
                while ((line = reader.readLine()) != null) {
                    builder.append(line);
                }
                reader.close();
                return builder.toString();
            } catch (IOException e) {
                e.printStackTrace();
                return null;
            }
        }

        public JSONObject asJsonObject() {
            try {
                return new JSONObject(asString());
            } catch (JSONException e) {
                e.printStackTrace();
                return null;
            }
        }

        public JSONArray asJsonArray() {
            try {
                return new JSONArray(asString());
            } catch (JSONException e) {
                e.printStackTrace();
                return null;
            }
        }

    }

}
