package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ImageView;

public class contenido extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contenido);

        ImageView continuar = findViewById(R.id.btncontinuar);
        ImageButton volverMenu = findViewById(R.id.inicio);

        continuar.setOnClickListener(new View.OnClickListener() {
            @Override

            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), juego.class);
                // abre la activity del juego
                startActivity(intent);
            }
        });

        volverMenu.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), MainActivity.class);
                // abre la activity del menu principal
                startActivity(intent);
            }
        });


    }
}
