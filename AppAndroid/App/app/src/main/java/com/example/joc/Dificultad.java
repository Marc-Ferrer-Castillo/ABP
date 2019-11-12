package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Dificultad extends AppCompatActivity {

    public static final int CONTENIDO_ACTIVITY = 1;
    public static final int REQUEST_CODE  = 1;

    public static boolean dificultadSeleccionada;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dificultad);

        Button facil = findViewById(R.id.facil);
        Button dificil = findViewById(R.id.dificil);
        final TextView tiempo = findViewById(R.id.tiempo);
        final Intent intentContenido = new Intent(getApplicationContext(), Contenido.class);

        facil.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {

                // Inicia la actividad
                dificultadSeleccionada = true;
                startActivityForResult(intentContenido, CONTENIDO_ACTIVITY);

            }
        });

        dificil.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick (View v){

                // Inicia la actividad
                dificultadSeleccionada = false;
                startActivityForResult(intentContenido, CONTENIDO_ACTIVITY);

            }
        });

        new CountDownTimer(30000, 1000) {

            public void onTick(long millisUntilFinished) {
                tiempo.setText("seconds remaining: " + millisUntilFinished / 1000);
            }

            public void onFinish() {

                // Vuelve al main
                finish();
            }
        }.start();

    }

    // Resultado de startActivityForResult
    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        // Si la actividad de la que volvemos
        if (requestCode == CONTENIDO_ACTIVITY) {

            // Y devuelve RESULT_OK
            if (resultCode == RESULT_OK) {

                // Devuelve RESULT OK a la clase Dificultad
                setResult(Dificultad.RESULT_OK);

                // Cerramos esta actividad también
                finish();
            }
        }
    }

}
