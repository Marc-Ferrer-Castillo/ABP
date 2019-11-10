package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;

public class contenido extends AppCompatActivity {

    private final byte MAX_PLANETAS = 3;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contenido);

        ImageView continuar = findViewById(R.id.btncontinuar);
        ImageButton volverMenu = findViewById(R.id.inicio);
        TextView informacion = findViewById(R.id.informacion);


        informacion.setText(MainActivity.planetas.get(MainActivity.planetaMostrado).getContenido());


        // Botón continuar
        continuar.setOnClickListener(new View.OnClickListener() {
            @Override

            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), juego.class);
                // abre la activity del juego
                startActivity(intent);
            }
        });

        // Botón salir
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
