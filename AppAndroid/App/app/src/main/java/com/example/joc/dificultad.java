package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import java.util.Locale;

public class dificultad extends AppCompatActivity {

    /*0=CATALAN  1=CASTELLANO  2=INGLES*/
    /*public static byte idioma;

    private String catalan = "ca";
    private String espanol = "es";
    private String ingles  = "en";*/

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dificultad);

        /*Button facil = findViewById(R.id.facil);
        Button dificil = findViewById(R.id.dificil);*/



       /* facil.setOnClickListener(new View.OnClickListener() {
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
        });*/
    }
}
