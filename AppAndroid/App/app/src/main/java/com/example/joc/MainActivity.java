package com.example.joc;

import android.content.res.Configuration;
import android.content.res.Resources;
import android.media.Image;
import android.os.Bundle;
import android.util.DisplayMetrics;
import android.view.View;
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

        cat.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale(catalan);
            }
        });

        esp.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale("es");
            }
        });

        eng.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                setLocale("en");
            }
        });

    }

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
