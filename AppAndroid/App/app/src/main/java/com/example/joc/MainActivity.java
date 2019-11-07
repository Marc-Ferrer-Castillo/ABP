package com.example.joc;

import android.content.Intent;
import android.content.res.Configuration;
import android.content.res.Resources;
import android.os.Bundle;
import android.util.DisplayMetrics;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

import androidx.appcompat.app.AppCompatActivity;
import java.util.Locale;

public class MainActivity extends AppCompatActivity {



    /*0=CATALAN  1=CASTELLANO  2=INGLES*/
    public static byte idioma;

    private String catalan = "ca";
    private String espanol = "es";
    private String ingles  = "en";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ImageView cat = findViewById(R.id.catalan);
        ImageView esp = findViewById(R.id.castellano);
        ImageView eng = findViewById(R.id.ingles);
        ImageView iniciar = findViewById(R.id.btniniciar);
        Button contenido = findViewById(R.id.contenido);
        Button juego = findViewById(R.id.juego);
        Button resultado = findViewById(R.id.resultado);

        // Click en INICIAR
        iniciar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), dificultad.class);
                // Dependiendo del idioma la variable idioma vale 0, 1 o 2
                if (Locale.getDefault().getDisplayLanguage() == espanol){
                    idioma = 1;
                }
                else if (Locale.getDefault().getDisplayLanguage() == catalan){
                    idioma = 0;
                }
                else {
                    idioma = 2;
                }
                // Inicia la actividad
                startActivity(intent);
            }
        });

        // Click en catalan
        cat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale(catalan);
            }
        });
        // Click en español
        esp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale(espanol);
            }
        });
        // Click en ingles
        eng.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale(ingles);
            }
        });

        /*BOTONES PROVISIONALES*/

        contenido.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), contenido.class);
                // Inicia la actividad
                startActivity(intent);
            }
        });
        juego.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), juego.class);
                // Inicia la actividad
                startActivity(intent);
            }
        });
        resultado.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), resultado.class);
                // Inicia la actividad
                startActivity(intent);
            }
        });


    }



    // Cambia el idioma  y recrea la actividad
    public void setLocale(String lang) {

        Locale locale = new Locale(lang);
        Resources res = getResources();
        DisplayMetrics dm = res.getDisplayMetrics();
        Configuration conf = res.getConfiguration();
        conf.locale = locale;
        res.updateConfiguration(conf, dm);
        recreate();
    }




}
