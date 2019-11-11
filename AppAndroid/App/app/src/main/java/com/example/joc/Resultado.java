package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.res.FontResourcesParserCompat;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

public class Resultado extends AppCompatActivity {


    public static int aciertos = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_resultado);



        TextView aciertosView = findViewById(R.id.aciertos);
        ImageButton salir = findViewById(R.id.inicio);
        final Intent intent = new Intent(getApplicationContext(), MainActivity.class);

        aciertosView.setText("El numero de aciertos es de " + String.valueOf(aciertos) );
        aciertos = 0;

        salir.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {

                // Inicia la actividad
                startActivity(intent);
            }
        });
    }
}
