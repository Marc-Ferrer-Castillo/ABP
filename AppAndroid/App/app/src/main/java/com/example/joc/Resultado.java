package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.res.FontResourcesParserCompat;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;

public class Resultado extends AppCompatActivity {


    public static int aciertos = 0;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_resultado);

        TextView aciertosView = findViewById(R.id.aciertos);
        ImageButton salir = findViewById(R.id.inicio);
        ImageView personaje =findViewById(R.id.personaje);
        TextView nombre = findViewById(R.id.nombre);
        TextView frase = findViewById(R.id.nombre);

        final Intent intent = new Intent(getApplicationContext(), MainActivity.class);

        if(aciertos < 3)
        {
            personaje.setImageResource(R.drawable.rocket);
        }
        else if (aciertos > 7)
        {
            personaje.setImageResource(R.drawable.narrador);
        }
        else
        {
            personaje.setImageResource(R.drawable.cat);
        }

        aciertosView.setText(getString(R.string.numAciertos) + String.valueOf(aciertos) );
        aciertos = 0;

        salir.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View v) {

                // envia result_OK y Cierra esta actividad
                setResult(Resultado.RESULT_OK);
                finish();
            }
        });
    }
}
