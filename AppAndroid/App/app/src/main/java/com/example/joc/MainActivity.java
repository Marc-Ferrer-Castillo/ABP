package com.example.joc;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.content.res.Configuration;
import android.content.res.Resources;
import android.net.Uri;
import android.os.Bundle;
import android.provider.Settings;
import android.util.DisplayMetrics;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import java.util.Locale;

public class MainActivity extends AppCompatActivity {

    public static final int REQUEST_CODE  = 1;

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




        // Controlem la versió d'Android que estem executant.
        if (android.os.Build.VERSION.SDK_INT >= 23)
        {
            // Si no s'ha concedit el permís de lectura
            if (ContextCompat.checkSelfPermission(this, Manifest.permission.READ_EXTERNAL_STORAGE)
                    != PackageManager.PERMISSION_GRANTED) {

                if (ActivityCompat.shouldShowRequestPermissionRationale(this,
                        Manifest.permission.READ_EXTERNAL_STORAGE)) {

                    // Obre el menu perque es donguin permissos
                    Intent intent = new Intent();
                    intent.setAction(Settings.ACTION_APPLICATION_DETAILS_SETTINGS);
                    Uri uri = Uri.fromParts("package", getPackageName(), null);
                    intent.setData(uri);
                    startActivity(intent);

                }
                else {
                    demanarPermisos();
                }
            }
            // Si s' ha concedit el permís
            else{

            }
        }
        // Si executem una versió anterior a la versió Marshmallow (6.0),
        // no cal demanar cap permís, i podem executar el nostre codi directament
        else
        {

        }



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

        /*-----------------------BOTONES PROVISIONALES------------------------------*/

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
        /*-----------------------BOTONES PROVISIONALES------------------------------*/

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

    // Cuando el usuario ha respondido a la solicitud de permisos en tiempo real
    @Override
    public void onRequestPermissionsResult(int requestCode, String[] permissions, int[] grantResults) {
        switch (requestCode) {
            case REQUEST_CODE: {
                // Si se han otorgado permisos
                if (grantResults.length > 0 && grantResults[0] == PackageManager.PERMISSION_GRANTED) {


                }
                // Si no
                else {
                    demanarPermisos();
                }
                return;
            }
        }
    }


    public void demanarPermisos(){
        // Demana permissos en temps d'execució
        ActivityCompat.requestPermissions(this,
                new String[]{Manifest.permission.READ_EXTERNAL_STORAGE}, REQUEST_CODE);

    }


}
