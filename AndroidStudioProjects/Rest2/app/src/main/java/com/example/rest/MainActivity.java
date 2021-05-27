package com.example.rest;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.DefaultItemAnimator;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.widget.Button;

import org.w3c.dom.Element;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    List<ListElement> elements;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        init();
    }

    public void init(){
        elements = new ArrayList<>();
        elements.add(new ListElement("11 razones", "Aitana"));
        elements.add(new ListElement("Teenage Dream", "Katy Perry"));
        elements.add(new ListElement("Hair", "Little Mix"));
        elements.add(new ListElement("Play date", "Melanie Martinez"));
        elements.add(new ListElement("Rythm inside", "Loic Nottet"));
        elements.add(new ListElement("Physical", "Dua Lipa"));
        elements.add(new ListElement("Physical", "Dua Lipa"));
        elements.add(new ListElement("Physical", "Dua Lipa"));
        elements.add(new ListElement("Physical", "Dua Lipa"));
        elements.add(new ListElement("Physical", "Dua Lipa"));
        elements.add(new ListElement("Physical", "Dua Lipa"));
        elements.add(new ListElement("Physical", "Dua Lipa"));



        ListAdapter listAdapter = new ListAdapter(elements, this);
        RecyclerView recyclerView = findViewById(R.id.listRecyclerView);
        recyclerView.setHasFixedSize(true);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        recyclerView.setAdapter(listAdapter);
        recyclerView.setItemAnimator(new DefaultItemAnimator());
    }

}