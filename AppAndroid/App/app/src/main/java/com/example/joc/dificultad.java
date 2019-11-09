package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.Locale;

public class dificultad extends AppCompatActivity {


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dificultad);

        Button facil = findViewById(R.id.facil);
        Button dificil = findViewById(R.id.dificil);
        final TextView tiempo = findViewById(R.id.tiempo);



        facil.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), contenido.class);
                // Inicia la actividad
                startActivity(intent);
            }
        });
        dificil.setOnClickListener(new View.OnClickListener()

        {
            @Override
            public void onClick (View v){
                Intent intent = new Intent(getApplicationContext(), contenido.class);
                // Inicia la actividad
                startActivity(intent);
            }
        });
        new CountDownTimer(30000, 1000) {

            public void onTick(long millisUntilFinished) {
                tiempo.setText("seconds remaining: " + millisUntilFinished / 1000);
            }

            public void onFinish() {
                Intent intent = new Intent(getApplicationContext(), MainActivity.class);
                // Inicia la actividad
                startActivity(intent);
            }
        }.start();
    }
}
