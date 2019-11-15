package com.example.joc;


import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;
import java.util.List;

public class Adaptador extends BaseAdapter {


    private List<Respuesta> respuestas;
    private Activity context;

    public Adaptador(Activity _context,List<Respuesta> _respuestas) {

        context = _context;
        respuestas = _respuestas;
    }



    public View getView(int position, View convertView, ViewGroup parent) {

        View view = convertView;
        CompleteListViewHolder viewHolder;

        if (convertView == null){
            LayoutInflater li = (LayoutInflater) context
                    .getSystemService(Context.LAYOUT_INFLATER_SERVICE);
            view = li.inflate(R.layout.place_respuesta, null);
            viewHolder = new CompleteListViewHolder(view);
            view.setTag(viewHolder);
        }else {
            viewHolder = (CompleteListViewHolder) view.getTag();
        }

        viewHolder.mTVItem.setText(respuestas.get(position).getRespuesta());
        view.setTag(position);

        return view;

    }


    @Override
    public int getCount() {
        return 0;
    }

    @Override
    public Object getItem(int i) {
        return null;
    }

    @Override
    public long getItemId(int i) {
        return 0;
    }

    private class CompleteListViewHolder {
        public TextView mTVItem;
        public CompleteListViewHolder(View base) {
            mTVItem = (TextView) base.findViewById(R.id.placeRespuesta);
        }
    }
}
