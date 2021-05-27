package com.example.rest;

public class ListElement {
    public String track;
    public String singer;

    public ListElement(String track, String singer) {
        this.track = track;
        this.singer = singer;
    }


    public String getTrack() {
        return track;
    }

    public void setTrack(String track) {
        this.track = track;
    }

    public String getSinger() {
        return singer;
    }

    public void setSinger(String singer) {
        this.singer = singer;
    }

}
