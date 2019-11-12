package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;
import java.io.File;

import static com.example.joc.MainActivity.DIRECTORIO_IMAGENES;

public class Contenido extends AppCompatActivity {


    private static final byte JUEGO_ACTIVITY = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contenido);

        Button continuar = findViewById(R.id.btncontinuar);
        ImageView imagenNarrador = findViewById(R.id.imagenNarrador);
        ImageButton inicio = findViewById(R.id.inicio);
        TextView informacion = findViewById(R.id.informacion);

        //EL TEXTO SE CARGA DEL PLANTA planetaMostrado
        informacion.setText(MainActivity.planetas.get(MainActivity.planetaMostrado).getContenido());

        //CARGA imagen3.png DEL DIRECTORIO imatges Y LO COLOCA EN EL imageview
        String fname = new File(DIRECTORIO_IMAGENES, "imagen2.png").getAbsolutePath();
        Bitmap myBitmap = BitmapFactory.decodeFile(fname);
        imagenNarrador.setImageBitmap(myBitmap);

        // Botón continuar
        continuar.setOnClickListener(new View.OnClickListener() {
            @Override

            public void onClick(View v) {
                Intent intent = new Intent(getApplicationContext(), Juego.class);
                // abre la activity del Juego
                startActivityForResult(intent, JUEGO_ACTIVITY);
            }
        });

        // Botón salir
        inicio.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Devuelve RESULT OK a la clase Dificultad
                setResult(Contenido.RESULT_OK);
                // Cierra esta actividad
                finish();
            }
        });


    }

    // Resultado de startActivityForResult
    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);

        // Si la actividad de la que volvemos
        if (requestCode == JUEGO_ACTIVITY) {

            // Y devuelve RESULT_OK
            if (resultCode == RESULT_OK) {

                // Devuelve RESULT OK a la clase Dificultad
                setResult(Contenido.RESULT_OK);

                // Cerramos esta actividad también
                finish();
            }
        }
    }
}
