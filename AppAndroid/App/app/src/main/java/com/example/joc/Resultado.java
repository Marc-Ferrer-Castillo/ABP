package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

public class Resultado extends AppCompatActivity {


    public static byte aciertos;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_resultado);

        aciertos = 0;

        TextView aciertos = findViewById(R.id.aciertos);

        aciertos.setText("El numero de aciertos es de " + String.valueOf(aciertos));

    }
}
