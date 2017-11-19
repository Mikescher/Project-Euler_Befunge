/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABACtVsuS4yoM/RWl4tlAexpBnHQoiprPuAuKZMeWFSt//EjCSRx3d2burUuVEz9k6ejoSLj9Qyvi2PaPBetzAD7+zTLs0gDg/+fSsksk1//VZRysLait"+
                                 "rdD6Hccux4bhr11GKO/JnRR5KdXv5kj3vG3WL4YhVjSY40i//Tifob10mQ2WYq1WJ+f9iAFATS5gS8W5H9WFsV3afjzRI18MhmpQ62fEf+QyEzCoNfrdvl28yxj3gzxA"+
                                 "U03Ni9X3LmNBLO3J5WWgaxPnziuWzP+Hs5r0QUVvkneT+rFNPBaP+mDqNLYifnH0TCbaUpLPjXLPTACzSu6bw2psaL6+MyeJKdomns2hjljMIRxtO030Mpl3OkNDcsbZ"+
                                 "hUcmhovvKXCaF1HgJ5TXneIaNzWiikNu9H4khGNyOZbYy92XOG7GUBjPuEk9dLqHTyiZQMKoT5DDvCOZuBOIiBZaV+UWVP6sTXGmeGuKAmeqeqafTNKBHjV1mCCO4D3T"+
                                 "l5EpSj3dVbn5ch71NCWNPmmSESTSEaWFVI1oIr2Oyc+ksQThahSXgRgfCGtns7t8KjefpQ+NFbU/jsdxJioRSU1Uxjmw5XgMZEKZp1x2ECVdZ6EIu5Db5AQE5DuX8SnF"+
                                 "FnPs8tUKDOvLlJbHyVNQapQr5FvPCFZoKsBXa6GO2yreooE9AcppiJREIdfIaUUBx4rk9haF3iWK6xrEIrf3lO8eqj1QDwcHFjrgbkK1b/uQizyV2ngIMzPaC/VezBqx"+
                                 "jRSFRoZtUZiqRBghqpGQ8e1y3c3t3pmVnCB5CiTnYTopZpcMGfEDp51318JjjwYHlbHbPxBK+oDLWOQ4VqKAqLD5JJMJuO/KQmXIN8gRBqqf2HMQNBQCR1tChtAsVutu"+
                                 "WUtUhFWBRSwdxABdZGIJSRGPGyU0kiOGTri1eyjlYCvNl5hXRrC6cnFVNzanfOOma5mEYQjren2zQgdO8W5OQZTctl37hOZzuM1q0l+3YQWuZ77p2qf1IlxfinPZhrOb"+
                                 "rn1ar8L1PDjneweAzEUadkCKWsj7tEW+CCdr1QAjuWSBUe+KmwvVaaNlKTrIBrEdgauY/BLeXoKnXQXW+krAPcfBOupLe3wVfO/+lsjAE9OI9FZzgbhgiwzWU3x4DE2p"+
                                 "6qPHX6tsiQCP9pQ26OEec0iowPuE0ent7Y0a7eevbyMMf/zQelIMbSnVOFUMZWOoc/XZB2MqcaZOkwxbHeJSG0GUiklXERHaLTXFMKlHziKhKTrR/p+mSY+sERNTSWdt"+
                                 "q58hHyduhi9xDeuRqeQLCc50tB3tOkfeDJz+SKLGLF8MtJl1be4/NcNtffHg1MxwWV172nsrug2nm8vv/C8uIuGho5xp8sqfKyNTtZz7n8QFl09bV3nIa9lAX62sDh8X"+
                                 "+sIATn4ifJR/Qfcax+v1G+ECHv//CwAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[3071];for(int i=0;i<3071;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<83&&y<37)?g[(int)(y*83+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<83&&y<37)g[(int)(y*83+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(2,3,0);
    gw(1,0,19);
    sa(1);
    sa(-1);
    sa(1);
    sa(-1);
    sa(1);
    sa(-1);
    sa(1);
    sa(-1);
    sa(1);
    sa(-1);
    sa(1);
    return 1;
}
private int _1(){
    t0=gr(1,0)-1;
    sa(gr(1,0));

    if(gr(1,0)!=8)return 115;else return 2;
}
private int _2(){
    gw(35,10,0);
    sp();
    sa(163);
    sa(164);
    return 3;
}
private int _3(){
    if(sp()!=0)return 4;else return 5;
}
private int _4(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((sr()%15)+21);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/15L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 3;
}
private int _5(){
    gw(2,0,1);
    sp();
    sa(1);
    sa(1);
    return 6;
}
private int _6(){
    gw(3,0,1);
    sa(0);
    sa(0);
    sa(gr(9,0)*gr(3,0));
    gw(3,0,gr(3,0)*gr(2,0));
    return 7;
}
private int _7(){
    gw(1,0,sp());
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+gr(1,0));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr()+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-10L);


    if(sp()!=0)return 114;else return 8;
}
private int _8(){
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+8L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+1L);


    if(sr()!=12)return 9;else return 10;
}
private int _9(){
    sa(sr());
    sa(sr());
    gw(2,0,sp());
    return 6;
}
private int _10(){
    gw(1,1,1);
    sp();
    return 11;
}
private int _11(){
    gw(4,0,1);
    return 12;
}
private int _12(){
    sa(0);
    sa(0);
    sa(0);
    sa(1);
    sa(0);
    sa(0);
    return 13;
}
private int _13(){
    if(sp()!=0)return 113;else return 14;
}
private int _14(){
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((sp()<gr(1,1))?1:0);

    sa(sp()*sp());

    sa(sp()*(gr(4,0)<=gr(1,1)?1L:0L));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(4,0)-1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+1L);


    if(sr()!=11)return 112;else return 15;
}
private int _15(){
    gw(35,gr(4,0)-1,gr(gr(4,0)+8,1)*(gr(4,0)<=gr(1,1)?1:0));
    t0=gr(4,0)-11;
    gw(4,0,gr(4,0)+1);
    sp();

    if((t0)!=0)return 12;else return 16;
}
private int _16(){
    gw(1,2,0);
    return 17;
}
private int _17(){
    if((gr(1,1)-1)>gr(1,2))return 18;else return 53;
}
private int _18(){
    gw(2,2,gr(1,2)+1);
    return 19;
}
private int _19(){
    if(gr(1,1)>gr(2,2))return 20;else return 52;
}
private int _20(){
    gw(3,2,gr(gr(1,2)+21,gr(1,2)));
    gw(4,2,gr(gr(1,2)+21,gr(2,2)));
    gw(35,gr(1,2),gr(35,gr(1,2))*gr(4,2));
    sa(14);
    sa(14);
    return 21;
}
private int _21(){
    if(sp()!=0)return 51;else return 22;
}
private int _22(){
    gw(35,gr(2,2),gr(35,gr(2,2))*gr(3,2));
    sp();
    sa(14);
    sa(14);
    return 23;
}
private int _23(){
    if(sp()!=0)return 50;else return 24;
}
private int _24(){
    gw(35,gr(2,2),gr(35,gr(2,2))-gr(35,gr(1,2)));
    sp();
    sa(14);
    sa(14);
    return 25;
}
private int _25(){
    if(sp()!=0)return 49;else return 26;
}
private int _26(){
    sp();
    sa(gr(35,gr(1,2)));
    sa(gr(gr(1,1)+20,gr(1,2)));
    sa(gr(1,1)-1);
    sa(gr(1,1)-1);
    return 27;
}
private int _27(){
    if(sp()!=0)return 48;else return 28;
}
private int _28(){
    sp();
    sa(gr(1,1));
    gw(2,1,gr(1,1));
    return 29;
}
private int _29(){
    if(sp()!=0)return 30;else return 33;
}
private int _30(){
    sa(sr());

    if(sp()!=0)return 31;else return 32;
}
private int _31(){
    sa(sr());
    gw(3,3,sp());
    {long v0=sp();sa(tm(sp(),v0));}

    sa(gr(3,3));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 30;
}
private int _32(){
    sp();
    sa(gr(2,1)-1);
    gw(2,1,gr(2,1)-1);
    return 29;
}
private int _33(){
    gw(1,0,sp());
    gw(35,gr(1,2),td(gr(35,gr(1,2)),gr(1,0)));
    sa(14);
    sa(14);
    return 34;
}
private int _34(){
    if(sp()!=0)return 47;else return 35;
}
private int _35(){
    sp();
    sa(gr(35,gr(2,2)));
    sa(gr(gr(1,1)+20,gr(2,2)));
    sa(gr(1,1)-1);
    sa(gr(1,1)-1);
    return 36;
}
private int _36(){
    if(sp()!=0)return 46;else return 37;
}
private int _37(){
    sp();
    sa(gr(1,1));
    gw(2,1,gr(1,1));
    return 38;
}
private int _38(){
    if(sp()!=0)return 39;else return 42;
}
private int _39(){
    sa(sr());

    if(sp()!=0)return 40;else return 41;
}
private int _40(){
    sa(sr());
    gw(3,3,sp());
    {long v0=sp();sa(tm(sp(),v0));}

    sa(gr(3,3));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 39;
}
private int _41(){
    sp();
    sa(gr(2,1)-1);
    gw(2,1,gr(2,1)-1);
    return 38;
}
private int _42(){
    gw(1,0,sp());
    gw(35,gr(2,2),td(gr(35,gr(2,2)),gr(1,0)));
    sa(14);
    sa(14);
    return 43;
}
private int _43(){
    if(sp()!=0)return 45;else return 44;
}
private int _44(){
    gw(2,2,gr(2,2)+1);
    sp();
    return 19;
}
private int _45(){
    sa(sp()-1L);

    sa(sr());
    sa(td(gr(sr()+21,gr(2,2)),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(2,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 43;
}
private int _46(){
    sa(sp()-1L);

    sa(gr(sr()+21,gr(2,2)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 36;
}
private int _47(){
    sa(sp()-1L);

    sa(sr());
    sa(td(gr(sr()+21,gr(1,2)),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(1,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 34;
}
private int _48(){
    sa(sp()-1L);

    sa(gr(sr()+21,gr(1,2)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 27;
}
private int _49(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    t0=gr(sr()+21,gr(2,2));
    sa(sp()+21L);

    sa(gr(1,2));
    {long v0=sp();t1=gr(sp(),v0);}
    sa(t0-t1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(2,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 25;
}
private int _50(){
    sa(sp()-1L);

    sa(sr());
    sa(gr(sr()+21,gr(2,2))*gr(3,2));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(2,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 23;
}
private int _51(){
    sa(sp()-1L);

    sa(sr());
    sa(gr(sr()+21,gr(1,2))*gr(4,2));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(1,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 21;
}
private int _52(){
    gw(1,2,gr(1,2)+1);
    return 17;
}
private int _53(){
    gw(1,2,gr(1,1)-2);
    t0=1;
    t1=3;
    return 54;
}
private int _54(){
    if(0>gr(1,2))return 55;else return 77;
}
private int _55(){
    t0=2;
    t1=3;
    sa(gr(1,1)-1);
    sa(gr(gr(1,1)+20,gr(1,1)-1)<0?1:0);
    return 56;
}
private int _56(){
    if(sp()!=0)return 73;else return 57;
}
private int _57(){
    sa(sr());

    if(sp()!=0)return 72;else return 58;
}
private int _58(){
    gw(19,2,gr(35,10));
    sp();
    sa(10);
    sa(10);
    return 59;
}
private int _59(){
    if(sp()!=0)return 71;else return 60;
}
private int _60(){
    gw(2,0,1);
    gw(3,0,1);
    sp();
    sa(1);
    sa(1);
    return 61;
}
private int _61(){
    sa(0);
    sa(0);
    sa(gr(9,2)*gr(3,0));
    gw(3,0,gr(3,0)*gr(2,0));
    return 62;
}
private int _62(){
    gw(1,0,sp());
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+gr(1,0));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr()+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-10L);


    if(sp()!=0)return 70;else return 63;
}
private int _63(){
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+8L);

    sa(3);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+1L);


    if(sr()!=12)return 64;else return 65;
}
private int _64(){
    sa(sr());
    sa(sr());
    gw(2,0,sp());
    gw(3,0,1);
    return 61;
}
private int _65(){
    gw(3,1,0);
    sp();
    return 66;
}
private int _66(){
    if((gr(gr(3,1)+9,1)-gr(gr(3,1)+9,3))!=0)return 69;else return 67;
}
private int _67(){
    t0=gr(3,1)-10;
    gw(3,1,gr(3,1)+1);

    if((t0)!=0)return 66;else return 68;
}
private int _68(){
    System.out.print(" = ");
    System.out.print(String.valueOf(gr(2,3))+" ");
    return 116;
}
private int _69(){
    System.out.print(String.valueOf(gr(gr(3,1)+9,3))+" ");
    System.out.print('\n');
    gw(2,3,gr(gr(3,1)+9,3)+gr(2,3));
    gw(1,1,gr(1,1)+1);
    t0=1;
    return 11;
}
private int _70(){
    sa(gr(sr()+9,2)*gr(3,0));
    gw(3,0,gr(3,0)*gr(2,0));
    return 62;
}
private int _71(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    sa(35);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 59;
}
private int _72(){
    sa(sp()-1L);

    sa(sr());
    sa(sr()+21);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(gr(sp(),v0));}
    sa((sp()<0)?1:0);
    return 56;
}
private int _73(){
    sa(sr());
    gw(1,2,sp());
    gw(35,gr(1,2),gr(35,gr(1,2))*-1);
    sa(14);
    sa(14);
    return 74;
}
private int _74(){
    if(sp()!=0)return 76;else return 75;
}
private int _75(){
    sp();
    return 57;
}
private int _76(){
    sa(sp()-1L);

    sa(sr());
    sa(gr(sr()+21,gr(1,2))*-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(1,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 74;
}
private int _77(){
    gw(2,2,gr(1,2)+1);
    return 78;
}
private int _78(){
    if(gr(1,1)>gr(2,2))return 79;else return 111;
}
private int _79(){
    gw(3,2,gr(gr(2,2)+21,gr(1,2)));
    gw(4,2,gr(gr(2,2)+21,gr(2,2)));
    gw(35,gr(1,2),gr(35,gr(1,2))*gr(4,2));
    sa(14);
    sa(14);
    return 80;
}
private int _80(){
    if(sp()!=0)return 110;else return 81;
}
private int _81(){
    gw(35,gr(2,2),gr(35,gr(2,2))*gr(3,2));
    sp();
    sa(14);
    sa(14);
    return 82;
}
private int _82(){
    if(sp()!=0)return 109;else return 83;
}
private int _83(){
    gw(35,gr(1,2),gr(35,gr(1,2))-gr(35,gr(2,2)));
    sp();
    sa(14);
    sa(14);
    return 84;
}
private int _84(){
    if(sp()!=0)return 108;else return 85;
}
private int _85(){
    sp();
    sa(gr(35,gr(1,2)));
    sa(gr(gr(1,1)+20,gr(1,2)));
    sa(gr(1,1)-1);
    sa(gr(1,1)-1);
    return 86;
}
private int _86(){
    if(sp()!=0)return 107;else return 87;
}
private int _87(){
    sp();
    sa(gr(1,1));
    gw(2,1,gr(1,1));
    return 88;
}
private int _88(){
    if(sp()!=0)return 89;else return 92;
}
private int _89(){
    sa(sr());

    if(sp()!=0)return 90;else return 91;
}
private int _90(){
    sa(sr());
    gw(3,3,sp());
    {long v0=sp();sa(tm(sp(),v0));}

    sa(gr(3,3));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 89;
}
private int _91(){
    sp();
    sa(gr(2,1)-1);
    gw(2,1,gr(2,1)-1);
    return 88;
}
private int _92(){
    gw(1,0,sp());
    gw(35,gr(1,2),td(gr(35,gr(1,2)),gr(1,0)));
    sa(14);
    sa(14);
    return 93;
}
private int _93(){
    if(sp()!=0)return 106;else return 94;
}
private int _94(){
    sp();
    sa(gr(35,gr(2,2)));
    sa(gr(gr(1,1)+20,gr(2,2)));
    sa(gr(1,1)-1);
    sa(gr(1,1)-1);
    return 95;
}
private int _95(){
    if(sp()!=0)return 105;else return 96;
}
private int _96(){
    sp();
    sa(gr(1,1));
    gw(2,1,gr(1,1));
    return 97;
}
private int _97(){
    if(sp()!=0)return 98;else return 101;
}
private int _98(){
    sa(sr());

    if(sp()!=0)return 99;else return 100;
}
private int _99(){
    sa(sr());
    gw(3,3,sp());
    {long v0=sp();sa(tm(sp(),v0));}

    sa(gr(3,3));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 98;
}
private int _100(){
    sp();
    sa(gr(2,1)-1);
    gw(2,1,gr(2,1)-1);
    return 97;
}
private int _101(){
    gw(1,0,sp());
    gw(35,gr(2,2),td(gr(35,gr(2,2)),gr(1,0)));
    sa(14);
    sa(14);
    return 102;
}
private int _102(){
    if(sp()!=0)return 104;else return 103;
}
private int _103(){
    gw(2,2,gr(2,2)+1);
    sp();
    return 78;
}
private int _104(){
    sa(sp()-1L);

    sa(sr());
    sa(td(gr(sr()+21,gr(2,2)),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(2,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 102;
}
private int _105(){
    sa(sp()-1L);

    sa(gr(sr()+21,gr(2,2)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 95;
}
private int _106(){
    sa(sp()-1L);

    sa(sr());
    sa(td(gr(sr()+21,gr(1,2)),gr(1,0)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(1,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 93;
}
private int _107(){
    t0=1;
    sa(sp()-1L);

    sa(gr(sr()+21,gr(1,2)));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 86;
}
private int _108(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    t0=gr(sr()+21,gr(1,2));
    sa(sp()+21L);

    sa(gr(2,2));
    {long v0=sp();t1=gr(sp(),v0);}
    sa(t0-t1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(1,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 84;
}
private int _109(){
    sa(sp()-1L);

    sa(sr());
    sa(gr(sr()+21,gr(2,2))*gr(3,2));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(2,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 82;
}
private int _110(){
    sa(sp()-1L);

    sa(sr());
    sa(gr(sr()+21,gr(1,2))*gr(4,2));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+21L);

    sa(gr(1,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 80;
}
private int _111(){
    t0=1;
    gw(1,2,gr(1,2)-1);
    return 54;
}
private int _112(){
    sa(sr());
    sa(sr());
    sa(sr());
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 13;
}
private int _113(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*gr(4,0));

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-1L);

    sa(sr());
    return 13;
}
private int _114(){
    sa(gr(sr()+9,0)*gr(3,0));
    gw(3,0,gr(3,0)*gr(2,0));
    return 7;
}
private int _115(){
    gw(1,0,t0);
    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 1;
}

public void main(){
    int c=0;
    while(c<116){
    switch(c){
    case 0:c=_0();break;
    case 1:c=_1();break;
    case 2:c=_2();break;
    case 3:c=_3();break;
    case 4:c=_4();break;
    case 5:c=_5();break;
    case 6:c=_6();break;
    case 7:c=_7();break;
    case 8:c=_8();break;
    case 9:c=_9();break;
    case 10:c=_10();break;
    case 11:c=_11();break;
    case 12:c=_12();break;
    case 13:c=_13();break;
    case 14:c=_14();break;
    case 15:c=_15();break;
    case 16:c=_16();break;
    case 17:c=_17();break;
    case 18:c=_18();break;
    case 19:c=_19();break;
    case 20:c=_20();break;
    case 21:c=_21();break;
    case 22:c=_22();break;
    case 23:c=_23();break;
    case 24:c=_24();break;
    case 25:c=_25();break;
    case 26:c=_26();break;
    case 27:c=_27();break;
    case 28:c=_28();break;
    case 29:c=_29();break;
    case 30:c=_30();break;
    case 31:c=_31();break;
    case 32:c=_32();break;
    case 33:c=_33();break;
    case 34:c=_34();break;
    case 35:c=_35();break;
    case 36:c=_36();break;
    case 37:c=_37();break;
    case 38:c=_38();break;
    case 39:c=_39();break;
    case 40:c=_40();break;
    case 41:c=_41();break;
    case 42:c=_42();break;
    case 43:c=_43();break;
    case 44:c=_44();break;
    case 45:c=_45();break;
    case 46:c=_46();break;
    case 47:c=_47();break;
    case 48:c=_48();break;
    case 49:c=_49();break;
    case 50:c=_50();break;
    case 51:c=_51();break;
    case 52:c=_52();break;
    case 53:c=_53();break;
    case 54:c=_54();break;
    case 55:c=_55();break;
    case 56:c=_56();break;
    case 57:c=_57();break;
    case 58:c=_58();break;
    case 59:c=_59();break;
    case 60:c=_60();break;
    case 61:c=_61();break;
    case 62:c=_62();break;
    case 63:c=_63();break;
    case 64:c=_64();break;
    case 65:c=_65();break;
    case 66:c=_66();break;
    case 67:c=_67();break;
    case 68:c=_68();break;
    case 69:c=_69();break;
    case 70:c=_70();break;
    case 71:c=_71();break;
    case 72:c=_72();break;
    case 73:c=_73();break;
    case 74:c=_74();break;
    case 75:c=_75();break;
    case 76:c=_76();break;
    case 77:c=_77();break;
    case 78:c=_78();break;
    case 79:c=_79();break;
    case 80:c=_80();break;
    case 81:c=_81();break;
    case 82:c=_82();break;
    case 83:c=_83();break;
    case 84:c=_84();break;
    case 85:c=_85();break;
    case 86:c=_86();break;
    case 87:c=_87();break;
    case 88:c=_88();break;
    case 89:c=_89();break;
    case 90:c=_90();break;
    case 91:c=_91();break;
    case 92:c=_92();break;
    case 93:c=_93();break;
    case 94:c=_94();break;
    case 95:c=_95();break;
    case 96:c=_96();break;
    case 97:c=_97();break;
    case 98:c=_98();break;
    case 99:c=_99();break;
    case 100:c=_100();break;
    case 101:c=_101();break;
    case 102:c=_102();break;
    case 103:c=_103();break;
    case 104:c=_104();break;
    case 105:c=_105();break;
    case 106:c=_106();break;
    case 107:c=_107();break;
    case 108:c=_108();break;
    case 109:c=_109();break;
    case 110:c=_110();break;
    case 111:c=_111();break;
    case 112:c=_112();break;
    case 113:c=_113();break;
    case 114:c=_114();break;
    case 115:c=_115();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
