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
import java.util.List;


public class Contenido extends AppCompatActivity {


    private static final byte JUEGO_ACTIVITY = 1;
    private int planetaMostrado;
     // Guarda en planetas la lista de planetas del json
     private List<Planeta> planetas = Importar.getPlanetas();


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contenido);

        Button continuar = findViewById(R.id.btncontinuar);
        ImageView imagenNarrador = findViewById(R.id.imagenNarrador);
        ImageButton inicio = findViewById(R.id.inicio);




        Intent intentDoble = getIntent();
        planetaMostrado = intentDoble.getIntExtra("planetaMostrado", 0);
        final boolean dificultadSeleccionada = intentDoble.getBooleanExtra("dificultad", false);

        cargarTexto();

        //CARGA imagen3.png DEL DIRECTORIO imatges Y LO COLOCA EN EL imageview
        String fname = new File(Importar.DIRECTORIO_IMAGENES, "imagen2.png").getAbsolutePath();
        Bitmap myBitmap = BitmapFactory.decodeFile(fname);
        imagenNarrador.setImageBitmap(myBitmap);

        // Botón continuar
        continuar.setOnClickListener(new View.OnClickListener() {
            @Override

            public void onClick(View v) {
                Intent intentContenido = new Intent(getApplicationContext(), Juego.class);

                intentContenido.putExtra("dificultad", dificultadSeleccionada);
                intentContenido.putExtra("planetaMostrado", planetaMostrado);
                // abre la activity del Juego

                startActivityForResult(intentContenido, JUEGO_ACTIVITY);
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

    private void cargarTexto() {
        TextView informacion = findViewById(R.id.informacion);
        //EL TEXTO SE CARGA DEL PLANTA planetaMostrado
        informacion.setText(planetas.get( planetaMostrado ).getContenido() );
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
            // Si se ha llegado a la ultima pregunta
            else{
                // muestra el siguiente contenido
                planetaMostrado++;
                cargarTexto();
            }
        }
    }
}
