package com.example.joc;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;
import androidx.annotation.NonNull;
import java.util.List;

public class RespuestaAdapter extends ArrayAdapter {
    Context contexto;
    List<Respuesta> respuestas;


    public RespuestaAdapter(@NonNull Context contexto, List<Respuesta> respuestas) {
        super(contexto, R.layout.place_respuesta, respuestas);

        this.contexto = contexto;
        this.respuestas = respuestas;
    }

    public View getView(int numRespuesta, View convertView, ViewGroup parent) {

        // Guarda en planetas la lista de planetas del json
        List<Planeta> planetas = Importar.getPlanetas();

        // Inflater
        LayoutInflater inflater = (LayoutInflater)contexto.getSystemService(Context.LAYOUT_INFLATER_SERVICE);

        // View donde ira el layout place_respuesta
        View rowView = inflater.inflate(R.layout.place_respuesta, null,true);

        // View donde va la respuesta
        TextView campoRespuesta = rowView.findViewById(R.id.placeRespuesta);


        Juego juego = new Juego();

        // Añade la respuesta al View campoRespuesta
        campoRespuesta.setText( planetas.get(MainActivity.getPlanetaMostrado()).
                getPreguntas().get( juego.getPreguntaMostrada() ).getRespuestas().get(numRespuesta).getRespuesta());

        // Guarda un int para saber qué respuesta se ha pulsado
        rowView.setTag(numRespuesta);


        // Retorna cada item de la grid con su layout y sus textos correspondientes
        return(rowView);
    }

}
