package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.res.FontResourcesParserCompat;

import android.os.Bundle;
import android.widget.TextView;

public class Resultado extends AppCompatActivity {


    public static int aciertos = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_resultado);



        TextView aciertosView = findViewById(R.id.aciertos);

        aciertosView.setText("El numero de aciertos es de " + String.valueOf(aciertos) );
        aciertos = 0;
    }
}
