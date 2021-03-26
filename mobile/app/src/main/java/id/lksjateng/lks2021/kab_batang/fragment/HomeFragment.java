package id.lksjateng.lks2021.kab_batang.fragment;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import org.json.JSONException;
import org.json.JSONObject;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;

import id.lksjateng.lks2021.kab_batang.MainActivity;
import id.lksjateng.lks2021.kab_batang.R;
import id.lksjateng.lks2021.kab_batang.util.Request;

public class HomeFragment extends Fragment {

    static final DateFormat BIRTHDAY = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss", Locale.ENGLISH);

    View root;
    TextView welcome;
    TextView dob;
    TextView nominal;
    TextView keuntungan;
    TextView gain;

    Button logout;

    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        root = inflater.inflate(R.layout.fragment_home, container, false);

        welcome = root.findViewById(R.id.home_welcome);
        dob = root.findViewById(R.id.home_dob);
        nominal = root.findViewById(R.id.home_nominal);
        keuntungan = root.findViewById(R.id.home_keuntungan);
        gain = root.findViewById(R.id.home_gain);

        logout = root.findViewById(R.id.home_logout);
        logout.setOnClickListener(this::logout_onClick);

        return root;
    }

    @Override
    public void onResume() {
        super.onResume();

        Request.get("Auth/Me", "application/json", false).thenAccept(res -> {
            if (res.code < 400) {
                try {
                    JSONObject json = res.asJsonObject();

                    String name = json.getString("name");
                    boolean female = json.getString("gender").equals("Female");
                    String date = DateFormat.getDateInstance(DateFormat.LONG).format(BIRTHDAY.parse(json.getString("birthdate")));
                    root.post(() -> {
                        welcome.setText("Hello, " + (female ? "Mrs. " : "Ms. ") + name);
                        dob.setText(date);
                        root.invalidate();
                    });
                } catch (JSONException | ParseException e) {
                    e.printStackTrace();
                }
            }
        });
    }

    void logout_onClick(View v) {
        ((MainActivity) getActivity()).logout();
    }

}