package com.example.joc;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.res.FontResourcesParserCompat;

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

public class Resultado extends AppCompatActivity {


    private static int aciertos = 0;

    public static int getAciertos() {
        return aciertos;
    }

    public static void setAciertos(int aciertos) {
        Resultado.aciertos = aciertos;
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_resultado);

        TextView aciertosView = findViewById(R.id.aciertos);
        ImageButton salir = findViewById(R.id.inicio);
        ImageView personaje =findViewById(R.id.personaje);
        TextView nombre = findViewById(R.id.nombre);
        TextView frase = findViewById(R.id.nombre);


        if(aciertos < 3)
        {
            //CARGA imagen3.png DEL DIRECTORIO imatges Y LO COLOCA EN EL imageview
            String fname = new File(Importar.DIRECTORIO_IMAGENES, "imagen1.png").getAbsolutePath();
            Bitmap myBitmap = BitmapFactory.decodeFile(fname);
            personaje.setImageBitmap(myBitmap);

        }
        else if (aciertos < 7)
        {
            //CARGA imagen3.png DEL DIRECTORIO imatges Y LO COLOCA EN EL imageview
            String fname = new File(Importar.DIRECTORIO_IMAGENES, "imagen2.png").getAbsolutePath();
            Bitmap myBitmap = BitmapFactory.decodeFile(fname);
            personaje.setImageBitmap(myBitmap);
        }
        else
        {
            //CARGA imagen3.png DEL DIRECTORIO imatges Y LO COLOCA EN EL imageview
            String fname = new File(Importar.DIRECTORIO_IMAGENES, "imagen3.png").getAbsolutePath();
            Bitmap myBitmap = BitmapFactory.decodeFile(fname);
            personaje.setImageBitmap(myBitmap);
        }

        aciertosView.setText(getString(R.string.numAciertos)+ "\t" + String.valueOf(aciertos) );
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
