package com.example.rest;

import android.content.Context;
import android.net.sip.SipSession;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import java.util.List;

public class ListAdapter extends RecyclerView.Adapter<ListAdapter.ViewHolder> {
    private List<ListElement> mData;
    private LayoutInflater mInflater;
    private Context context;

    public ListAdapter(List<ListElement> itemList, Context context){
        this.mInflater = LayoutInflater.from(context);
        this.context = context;
        this.mData = itemList;
    }

    @Override
    public int getItemCount() {
        return mData.size();
    }

    @Override
    public ListAdapter.ViewHolder onCreateViewHolder(ViewGroup parent, int viewType){
        View view = mInflater.inflate(R.layout.list_element, null);
        return new ListAdapter.ViewHolder(view);
    }

    @Override
    public void onBindViewHolder(final ListAdapter.ViewHolder holder, final int position) {
        holder.binData(mData.get(position));
    }


    public void setItems(List<ListElement> items){
        mData = items;
    }

    public static class ViewHolder extends RecyclerView.ViewHolder{
        ImageView iconImage, deleteImage;
        TextView track, singer;
        AdapterView.OnItemClickListener listener;

        ViewHolder(View itemView){
            super(itemView);
            iconImage = itemView.findViewById(R.id.iconImageView);
            track = itemView.findViewById(R.id.trackTextView);
            singer = itemView.findViewById(R.id.singerTextView);
            deleteImage = itemView.findViewById(R.id.deleteImageView);


        }

        void binData(final ListElement item){
            track.setText(item.getTrack());
            singer.setText(item.getSinger());
        }


    }

}
