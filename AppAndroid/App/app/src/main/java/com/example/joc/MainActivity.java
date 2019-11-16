package com.example.joc;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.content.res.Configuration;
import android.content.res.Resources;
import android.net.Uri;
import android.os.Bundle;
import android.os.Environment;
import android.provider.Settings;
import android.util.DisplayMetrics;
import android.view.View;
import android.widget.ImageView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;

public class MainActivity extends AppCompatActivity {

    // Idiomas
    private static final String catalan = "cat";
    private static final String espanol = "spa";
    private static final String ingles  = "eng";
    public static final int ACTIVITY_DIFICULTAD = 1;


    /*Iterador de planetas*/
    private static int planetaMostrado;
    // Como mucho hay 3 planetas por idioma
    private static int ultimoPlaneta = planetaMostrado + 3;
    /*Según el idioma seleccionado se empezara por un planeta u otro. Por defecto es el idioma de sistema*/
    private static String idiomaSeleccionado = Locale.getDefault().getISO3Language();


    public static int getUltimoPlaneta() {
        return ultimoPlaneta;
    }


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        ImageView cat = findViewById(R.id.catalan);
        ImageView esp = findViewById(R.id.castellano);
        ImageView eng = findViewById(R.id.ingles);
        ImageView iniciar = findViewById(R.id.btniniciar);


        // Controla que haya permisos de lectura
        controlarPermisos();



        // Click en INICIAR
        iniciar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {



                // Dependiendo del idiomaMostrado se empiza por un planeta u otro
                if (idiomaSeleccionado.equals(catalan) ){

                    planetaMostrado = 0;
                }
                else if (idiomaSeleccionado.equals(espanol)){

                    planetaMostrado = 3;
                }
                else {

                    planetaMostrado = 6;

                }
                //El último planeta sera el planeta mostrado + 2 posiciones
                ultimoPlaneta = planetaMostrado + 2 ;

                Intent intentPlaneta = new Intent(MainActivity.this, Dificultad.class);
                intentPlaneta.putExtra("planetaMostrado", planetaMostrado);

                // Inicia la actividad
                startActivityForResult(intentPlaneta, ACTIVITY_DIFICULTAD);
            }
        });


        // Click en catalan
        cat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale("ca");
                planetaMostrado = 0;
                idiomaSeleccionado = catalan;

            }
        });
        // Click en español
        esp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale("es");
                planetaMostrado = 3;
                idiomaSeleccionado = espanol;

            }
        });
        // Click en ingles
        eng.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale("en");
                planetaMostrado = 6;
                idiomaSeleccionado = ingles;

            }
        });


    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        // Si la actividad de la que volvemos
        if (requestCode == ACTIVITY_DIFICULTAD) {

            // Y devuelve RESULT_OK
            if (resultCode == RESULT_OK) {

                //Vuelve el iterador a 0
                planetaMostrado = 0;
                //recreate();
            }
        }
    }

    // Controla permisos de lectura
    private void controlarPermisos() {

        // Objeto para importar
        Importar contenido = new Importar();

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
                contenido.leerContenido();
            }
        }
        // Si executem una versió anterior a la versió Marshmallow (6.0),
        // no cal demanar cap permís, i podem executar el nostre codi directament
        else
        {
            contenido.leerContenido();
        }
    }

    // Cambia el idiomaMostrado  y recrea la actividad
    private void setLocale(String lang) {

        Locale locale = new Locale(lang);
        Resources res = getResources();
        DisplayMetrics dm = res.getDisplayMetrics();
        Configuration conf = res.getConfiguration();
        conf.locale = locale;
        res.updateConfiguration(conf, dm);
        recreate();
    }

    // Cuando el usuario ha respondido a la solicitud de permisos en tiempo de ejecucion
    @Override
    public void onRequestPermissionsResult(int requestCode, String[] permissions, int[] grantResults) {
        switch (requestCode) {
            case ACTIVITY_DIFICULTAD: {
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

    // Pide permisos de lectura al usuario
    public void demanarPermisos(){
        // Demana permissos en temps d'execució
        ActivityCompat.requestPermissions(this,
                new String[]{Manifest.permission.READ_EXTERNAL_STORAGE}, ACTIVITY_DIFICULTAD);

    }


}
