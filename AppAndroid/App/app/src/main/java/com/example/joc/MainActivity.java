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

    // Lista de planetas
    public static  List<Planeta> planetas = new ArrayList<Planeta>();
    // Lista de personajes
    public static  List<Personaje> personajes = new ArrayList<Personaje>();

    public static final int REQUEST_CODE  = 1;

    /*Iterador de planetas*/
    public static byte planetaMostrado;

    // Como mucho hay 3 planetas por idioma
    public static int ultimoPlaneta;

    /*Según el idioma seleccionado se empezara por un planeta u otro. Por defecto es el idioma de sistema*/
    public static String idiomaSeleccionado = Locale.getDefault().getISO3Language();
    private static final String catalan = "cat";
    private static final String espanol = "spa";
    private static final String ingles  = "eng";

    /*RUTAS A LOS FICHEROS JSON E IMAGENES*/
    public static final String SEPARADOR             = File.separator;
    public static final String DIRECTORIO_CONTENIDO_ = Environment.getExternalStorageDirectory() + SEPARADOR + "contingut del joc";
    public static final String RUTA_PLANETAS         = DIRECTORIO_CONTENIDO_ + SEPARADOR + "planetas" + SEPARADOR + "planetas.JSON";
    public static final String RUTA_PJS              = DIRECTORIO_CONTENIDO_ + SEPARADOR + "personatges" + SEPARADOR + "personatges.JSON";
    public static final String DIRECTORIO_IMAGENES   = DIRECTORIO_CONTENIDO_ + SEPARADOR + "personatges"+ SEPARADOR + "imatges";

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

        //Vuelve el iterador a 0
        planetaMostrado = 0;

        // Click en INICIAR
        iniciar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intentDificultad = new Intent(getApplicationContext(), Dificultad.class);

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
                ultimoPlaneta = planetaMostrado + 2;

                // Inicia la actividad
                startActivity(intentDificultad);
            }
        });


        // Click en catalan
        cat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale(catalan);
                planetaMostrado = 0;
                idiomaSeleccionado = "ca";
            }
        });
        // Click en español
        esp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale(espanol);
                planetaMostrado = 3;
                idiomaSeleccionado = "es";
            }
        });
        // Click en ingles
        eng.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale(ingles);
                planetaMostrado = 6;
                idiomaSeleccionado = "en";
            }
        });



    }

    // Controla permisos de lectura
    private void controlarPermisos() {

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
                deserializarJsons();
            }
        }
        // Si executem una versió anterior a la versió Marshmallow (6.0),
        // no cal demanar cap permís, i podem executar el nostre codi directament
        else
        {
            deserializarJsons();
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

    // Cuando el usuario ha respondido a la solicitud de permisos en tiempo real
    @Override
    public void onRequestPermissionsResult(int requestCode, String[] permissions, int[] grantResults) {
        switch (requestCode) {
            case REQUEST_CODE: {
                // Si se han otorgado permisos
                if (grantResults.length > 0 && grantResults[0] == PackageManager.PERMISSION_GRANTED) {

                    deserializarJsons();
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
                new String[]{Manifest.permission.READ_EXTERNAL_STORAGE}, REQUEST_CODE);

    }

    // Lee, deserializa los archivos JSON y los añade a la lista de objetos
    public void deserializarJsons(){
        Gson gson = new Gson();

        try {
            BufferedReader lectorPlanetas = new BufferedReader(new FileReader(RUTA_PLANETAS));
            BufferedReader lectorPjs = new BufferedReader(new FileReader(RUTA_PJS));

            planetas = gson.fromJson(lectorPlanetas, new TypeToken<List<Planeta>>(){}.getType());
            personajes = gson.fromJson(lectorPjs, new TypeToken<List<Personaje>>(){}.getType());

            Toast.makeText(this, "Contenidos Cargados Correctamente",
                    Toast.LENGTH_LONG).show();

        } catch (IOException e) {
            e.printStackTrace();
            Toast.makeText(this, "NO S'HA TROVAT " + Environment.getExternalStorageDirectory() + "/ contingut del joc",
                    Toast.LENGTH_LONG).show();
        }
    }
}
