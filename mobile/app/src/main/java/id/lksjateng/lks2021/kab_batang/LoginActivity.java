package id.lksjateng.lks2021.kab_batang;

import androidx.appcompat.app.AppCompatActivity;

import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import id.lksjateng.lks2021.kab_batang.util.Request;

public class LoginActivity extends AppCompatActivity {

    EditText email;
    EditText password;

    Button submit;

    SharedPreferences secrets;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        email = findViewById(R.id.login_email);
        password = findViewById(R.id.login_password);
        submit = findViewById(R.id.login_submit);

        submit.setOnClickListener(this::submit_onClick);

        secrets = getSharedPreferences("secrets", MODE_PRIVATE);
    }

    void submit_onClick(View v) {
        String email = this.email.getText().toString().trim();
        String password = this.password.getText().toString();

        SharedPreferences.Editor editor = Request.getSecret().edit();
        editor.putString("email", email);
        editor.putString("password", password);
        editor.apply();

        String auth = Request.getAuth();
        if (auth != null) {
            finish();
        }
    }

}