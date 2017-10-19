/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtmk2PozgQhv+KQ3ouQUxjlwPpqIVW2sveZo9zGKUvK3H1Kafe/z4FzoexjTHd4Am0LUWNoZqXx1UUL1HO5CcOQsg2wEAZ0oqFk7uMUHJ/B5X7gWO9"+
                                 "iynpfkS5BcqFvu+iXJSLclEuykW5KBdK7rqPGEM9GuW85dwjyk0o56GpRXxJOXVfNyDKfVhuxFio3NhriHIWuU50J8pT13JiT7lu1Brk9H2jEhjlPnXSKBflliS37Y4o"+
                                 "tzq5ySSj3B+VM2P1SMuRKPfV5MxYQ8oaatnzteXmGFEuykW5LyCXh5VjYeVoWDkRVi4JK/dPWDnHdyhzyAVezN2q7ztY9X0XuGcGXsx198zAo0r+/zfZVTQ7JiT5dUz+"+
                                 "S87zi74fxTMq/UpfvpHXOYValieUqHj9neEH8MPx89cschVluahYXtMU8rZuKmgm/DLhzWR/mZDkZ0Iwdr9PdxiF+9tNno9LwHtWipwdU1rn7PU9O4gc2gng5EXkvJ1w"+
                                 "nOyzvcj37XQvKOBfCiKt/RPQXlcTfa3Sk/qv/ZMPjooAXmK22Z7eGG6kjCIaFaPW2La8dVrjymdjVvlDa9xdgjdN7+SQ81vW7hpXrhPKcRZFmYuC72pgTQ0UILe4KJjc"+
                                 "AlFQucV6z1LJ7J+6rcqSb88FfvWKc0VJ7aos6iNNy0K4T1iVZRtXOuOq8tBGHcyoE1Ym2eLu7bGZbgdLHWMx1BEnU3duT2eLOmf07SnHK6ZFzYo6paUA3CoFL2ooRedU"+
                                 "l9iDoCVGYOxBAG4dLFH0gPsx4qVz7Eyqo2/uiGesM0qlA0nHfOhA0jEnXfZIdFylAwcdokkyxEytdIhGH4kO0SQZYqYDdPRKB310Mnc7BvWzQvhHcyfpQNK5KpO1dODO"+
                                 "3WZ7fmsgASEPEnJeuko7crLRcd/cgewtBh15anPX0DFJR2ejOymt0kV3q0xJ1tTnQM/M7D2T2Juz/xWPjn1PN5tvzeP4hW42WU3Zs5y86rnjVzo2QAeSztIzifIaF4aO"+
                                 "9h4xK1PScRed2jMzC139+SseE+tBBwodH67MW8+00aWfv+Ixsf2louXu5lOclan2TBtd/2LOQid6j1grk8vnglfPtNE5vPYcdHnvEc1nZiN8pnxW633zMe876TOzET7z"+
                                 "SscMOv75Kx4T61eZXKXz9Zkto0YX+IngUZmqz8xG+EwbXeDK7L/NrT4zG+EzbXQBKlP0bHeH1Wf65Q7uvSU83Ynz5lsSTqDO+42fw2dmVjoEavzxtXU2bwCl2jrd3+N8"+
                                 "jE73x8o1uU/h8Jm+dFCqrfOR6VSfOUh3a53tW04pC/Qx6Uyf6ZO7Ox08NJ3pMwfpbq3z8XNn+kyTrnnrNnIH994yJZ3rrVuNcg7NZ0p3Zfeaw99qD48xuZtgaD7zSmfz"+
                                 "mgun4zodrIZO9ZnSf6yJTvWZV7pVVebNZ64vd6bPbBlXQmf6zPXRqT5zTXSmz1wTnekz10en+sy10CGTdMbSbjaeuDDt5rR0/c5YjinUJB0YdFCYdnOpdNyg44VpN5dK"+
                                 "R+9094d680ZaqJZlqXTdyrzTQaHazaXS8R46vorcWStTdsxLfS6Zjum54yodWzidtTJvdHzhdEplanZzlZUJKt2SK7P5jtL6RLjRwXR0yikq7Rf1+q8wJ6GrEpLYf2ks"+
                                 "Jjl/d/wGS+iz/X1bAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[23421];for(int i=0;i<23421;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<111&&y<211)?g[(int)(y*111+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<111&&y<211)g[(int)(y*111+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(2,1,0);
    gw(2,3,2520);
    gw(3,1,0);
    gw(108,99,32);
    sa(9999);
    sa(9999);
    return 1;
}
private int _1(){
    if(sp()!=0)return 205;else return 2;
}
private int _2(){
    gw(2,0,1);
    sp();
    return 3;
}
private int _3(){
    gw(3,0,gr(2,0)+1);
    return 4;
}
private int _4(){
    gw(4,0,gr(3,0)+1);
    return 5;
}
private int _5(){
    gw(5,0,gr(4,0)+1);
    return 6;
}
private int _6(){
    gw((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0),88);
    gw(3,1,gr(3,1)+1);
    t0=gr(5,0)-9;
    gw(5,0,gr(5,0)+1);
    return 7;
}
private int _7(){
    if((t0)!=0)return 6;else return 8;
}
private int _8(){
    t0=gr(4,0)-8;
    gw(4,0,gr(4,0)+1);

    if((t0)!=0)return 5;else return 9;
}
private int _9(){
    t0=gr(3,0)-7;
    gw(3,0,gr(3,0)+1);

    if((t0)!=0)return 4;else return 10;
}
private int _10(){
    t0=gr(2,0)-6;
    gw(2,0,gr(2,0)+1);

    if((t0)!=0)return 3;else return 11;
}
private int _11(){
    if(gr(3,1)!=1)return 13;else return 12;
}
private int _12(){
    System.out.print(String.valueOf(gr(1,4))+" ");
    System.out.print(String.valueOf(gr(2,4))+" ");
    System.out.print(String.valueOf(gr(3,4))+" ");
    System.out.print(String.valueOf(gr(4,4))+" ");
    return 206;
}
private int _13(){
    gw(2,1,gr(2,1)+1);
    gw(3,1,0);
    gw(2,0,1);
    return 14;
}
private int _14(){
    gw(3,0,gr(2,0)+1);
    return 15;
}
private int _15(){
    gw(4,0,gr(3,0)+1);
    return 16;
}
private int _16(){
    gw(5,0,gr(4,0)+1);
    return 17;
}
private int _17(){
    if(gr((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0))!=88)return 18;else return 22;
}
private int _18(){
    t0=gr(5,0)-9;
    gw(5,0,gr(5,0)+1);

    if((t0)!=0)return 17;else return 19;
}
private int _19(){
    t0=gr(4,0)-8;
    gw(4,0,gr(4,0)+1);

    if((t0)!=0)return 16;else return 20;
}
private int _20(){
    t0=gr(3,0)-7;
    gw(3,0,gr(3,0)+1);

    if((t0)!=0)return 15;else return 21;
}
private int _21(){
    t0=gr(2,0)-6;
    gw(2,0,gr(2,0)+1);

    if((t0)!=0)return 14;else return 11;
}
private int _22(){
    gw(1,6,gr(2,0)*gr(2,3));
    gw(2,6,gr(3,0)*gr(2,3));
    gw(3,6,gr(4,0)*gr(2,3));
    gw(4,6,gr(5,0)*gr(2,3));
    gw(7,6,0);
    return 23;
}
private int _23(){
    t0=gr(7,6);
    sa(gr(7,6));
    gw(7,6,gr(7,6)+1);

    if((t0)!=0)return 24;else return 204;
}
private int _24(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 25;else return 203;
}
private int _25(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 26;else return 202;
}
private int _26(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 27;else return 201;
}
private int _27(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 28;else return 200;
}
private int _28(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 29;else return 199;
}
private int _29(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 30;else return 198;
}
private int _30(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 31;else return 197;
}
private int _31(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 32;else return 196;
}
private int _32(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 33;else return 195;
}
private int _33(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 34;else return 194;
}
private int _34(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 35;else return 193;
}
private int _35(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 36;else return 192;
}
private int _36(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 37;else return 191;
}
private int _37(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 38;else return 190;
}
private int _38(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 39;else return 189;
}
private int _39(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 40;else return 188;
}
private int _40(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 41;else return 187;
}
private int _41(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 42;else return 186;
}
private int _42(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 43;else return 185;
}
private int _43(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 44;else return 184;
}
private int _44(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 45;else return 183;
}
private int _45(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 46;else return 182;
}
private int _46(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 47;else return 181;
}
private int _47(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 48;else return 180;
}
private int _48(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 49;else return 179;
}
private int _49(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 50;else return 178;
}
private int _50(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 51;else return 177;
}
private int _51(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 52;else return 176;
}
private int _52(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 53;else return 175;
}
private int _53(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 54;else return 174;
}
private int _54(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 55;else return 173;
}
private int _55(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 56;else return 172;
}
private int _56(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 57;else return 171;
}
private int _57(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 58;else return 170;
}
private int _58(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 59;else return 169;
}
private int _59(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 60;else return 167;
}
private int _60(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 61;else return 165;
}
private int _61(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 62;else return 163;
}
private int _62(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 63;else return 161;
}
private int _63(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 64;else return 159;
}
private int _64(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 65;else return 157;
}
private int _65(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 66;else return 155;
}
private int _66(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 67;else return 153;
}
private int _67(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 68;else return 151;
}
private int _68(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 69;else return 149;
}
private int _69(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 70;else return 147;
}
private int _70(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 146;else return 71;
}
private int _71(){
    sp();

    if((gr(3,6))!=0)return 72;else return 23;
}
private int _72(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6));
    gw(3,7,td(gr(4,6)*gr(2,3),gr(3,6)));
    return 73;
}
private int _73(){
    t0=gr(7,7);
    sa(gr(7,7));
    gw(7,7,gr(7,7)+1);

    if((t0)!=0)return 74;else return 145;
}
private int _74(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 75;else return 144;
}
private int _75(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 76;else return 143;
}
private int _76(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 77;else return 142;
}
private int _77(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 78;else return 141;
}
private int _78(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 79;else return 140;
}
private int _79(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 80;else return 139;
}
private int _80(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 81;else return 138;
}
private int _81(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 82;else return 137;
}
private int _82(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 83;else return 136;
}
private int _83(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 84;else return 135;
}
private int _84(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 85;else return 134;
}
private int _85(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 86;else return 133;
}
private int _86(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 87;else return 132;
}
private int _87(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 88;else return 131;
}
private int _88(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 89;else return 130;
}
private int _89(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 90;else return 129;
}
private int _90(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 91;else return 128;
}
private int _91(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 92;else return 126;
}
private int _92(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 93;else return 124;
}
private int _93(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 94;else return 122;
}
private int _94(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 95;else return 120;
}
private int _95(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 96;else return 118;
}
private int _96(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 117;else return 97;
}
private int _97(){
    sp();

    if((gr(2,7))!=0)return 99;else return 98;
}
private int _98(){
    sa(4);
    return 73;
}
private int _99(){
    gw(7,8,0);
    gw(1,8,gr(1,7));
    gw(2,8,td(gr(3,7)*gr(2,3),gr(2,7)));
    return 100;
}
private int _100(){
    t0=gr(7,8);
    sa(gr(7,8));
    gw(7,8,gr(7,8)+1);

    if((t0)!=0)return 101;else return 116;
}
private int _101(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 102;else return 115;
}
private int _102(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 103;else return 114;
}
private int _103(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 104;else return 113;
}
private int _104(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 109;else return 105;
}
private int _105(){
    sp();

    if((gr(2,8))!=0)return 106;else return 100;
}
private int _106(){
    gw(1,9,td(gr(1,8)*gr(2,3),gr(2,8)));
    return 107;
}
private int _107(){
    if(((((td(gr(1,9),gr(2,3)))-gr(2,1)!=0)?1:0)+((tm(gr(1,9),gr(2,3))!=0)?1L:0L))!=0)return 100;else return 108;
}
private int _108(){
    gw(3,1,gr(3,1)+1);
    gw(1,4,gr(2,0));
    gw(2,4,gr(3,0));
    gw(3,4,gr(4,0));
    gw(4,4,gr(5,0));
    return 18;
}
private int _109(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 112;else return 110;
}
private int _110(){
    sp();

    if((gr(1,8))!=0)return 111;else return 100;
}
private int _111(){
    gw(1,9,td(gr(2,8)*gr(2,3),gr(1,8)));
    return 107;
}
private int _112(){
    sp();
    return 73;
}
private int _113(){
    gw(1,9,td(gr(1,8)*gr(2,8),gr(2,3)));
    sp();
    return 107;
}
private int _114(){
    gw(1,9,gr(2,8)-gr(1,8));
    sp();
    return 107;
}
private int _115(){
    gw(1,9,gr(1,8)-gr(2,8));
    sp();
    return 107;
}
private int _116(){
    gw(1,9,gr(1,8)+gr(2,8));
    sp();
    return 107;
}
private int _117(){
    sp();
    return 23;
}
private int _118(){
    sp();

    if((gr(2,7))!=0)return 119;else return 98;
}
private int _119(){
    gw(7,8,0);
    gw(1,8,gr(2,7));
    gw(2,8,td(gr(3,7)*gr(2,3),gr(1,7)));
    return 100;
}
private int _120(){
    sp();

    if((gr(2,7))!=0)return 121;else return 98;
}
private int _121(){
    gw(7,8,0);
    gw(1,8,gr(1,7));
    gw(2,8,td(gr(2,7)*gr(2,3),gr(3,7)));
    return 100;
}
private int _122(){
    sp();

    if((gr(2,7))!=0)return 123;else return 98;
}
private int _123(){
    gw(7,8,0);
    gw(1,8,gr(3,7));
    gw(2,8,td(gr(2,7)*gr(2,3),gr(1,7)));
    return 100;
}
private int _124(){
    sp();

    if((gr(2,7))!=0)return 125;else return 98;
}
private int _125(){
    gw(7,8,0);
    gw(1,8,td(gr(1,7)*gr(2,3),gr(3,7)));
    gw(2,8,gr(2,7));
    return 100;
}
private int _126(){
    sp();

    if((gr(2,7))!=0)return 127;else return 98;
}
private int _127(){
    gw(7,8,0);
    gw(1,8,td(gr(1,7)*gr(2,3),gr(2,7)));
    gw(2,8,gr(3,7));
    return 100;
}
private int _128(){
    gw(7,8,0);
    gw(1,8,gr(1,7));
    gw(2,8,td(gr(3,7)*gr(2,7),gr(2,3)));
    sp();
    return 100;
}
private int _129(){
    gw(7,8,0);
    gw(1,8,gr(2,7));
    gw(2,8,td(gr(3,7)*gr(1,7),gr(2,3)));
    sp();
    return 100;
}
private int _130(){
    gw(7,8,0);
    gw(1,8,gr(1,7));
    gw(2,8,td(gr(2,7)*gr(3,7),gr(2,3)));
    sp();
    return 100;
}
private int _131(){
    gw(7,8,0);
    gw(1,8,gr(3,7));
    gw(2,8,td(gr(2,7)*gr(1,7),gr(2,3)));
    sp();
    return 100;
}
private int _132(){
    gw(7,8,0);
    gw(1,8,td(gr(1,7)*gr(3,7),gr(2,3)));
    gw(2,8,gr(2,7));
    sp();
    return 100;
}
private int _133(){
    gw(7,8,0);
    gw(1,8,td(gr(1,7)*gr(2,7),gr(2,3)));
    gw(2,8,gr(3,7));
    sp();
    return 100;
}
private int _134(){
    gw(7,8,0);
    gw(1,8,gr(1,7));
    gw(2,8,gr(3,7)-gr(2,7));
    sp();
    return 100;
}
private int _135(){
    gw(7,8,0);
    gw(1,8,gr(2,7));
    gw(2,8,gr(3,7)-gr(1,7));
    sp();
    return 100;
}
private int _136(){
    gw(7,8,0);
    gw(1,8,gr(1,7));
    gw(2,8,gr(2,7)-gr(3,7));
    sp();
    return 100;
}
private int _137(){
    gw(7,8,0);
    gw(1,8,gr(3,7));
    gw(2,8,gr(2,7)-gr(1,7));
    sp();
    return 100;
}
private int _138(){
    gw(7,8,0);
    gw(1,8,gr(1,7)-gr(3,7));
    gw(2,8,gr(2,7));
    sp();
    return 100;
}
private int _139(){
    gw(7,8,0);
    gw(1,8,gr(1,7)-gr(2,7));
    gw(2,8,gr(3,7));
    sp();
    return 100;
}
private int _140(){
    gw(7,8,0);
    gw(1,8,gr(1,7));
    gw(2,8,gr(3,7)+gr(2,7));
    sp();
    return 100;
}
private int _141(){
    gw(7,8,0);
    gw(1,8,gr(2,7));
    gw(2,8,gr(3,7)+gr(1,7));
    sp();
    return 100;
}
private int _142(){
    gw(7,8,0);
    gw(1,8,gr(1,7));
    gw(2,8,gr(2,7)+gr(3,7));
    sp();
    return 100;
}
private int _143(){
    gw(7,8,0);
    gw(1,8,gr(3,7));
    gw(2,8,gr(2,7)+gr(1,7));
    sp();
    return 100;
}
private int _144(){
    gw(7,8,0);
    gw(1,8,gr(1,7)+gr(3,7));
    gw(2,8,gr(2,7));
    sp();
    return 100;
}
private int _145(){
    gw(7,8,0);
    gw(1,8,gr(1,7)+gr(2,7));
    gw(2,8,gr(3,7));
    sp();
    return 100;
}
private int _146(){
    gw((gr(2,0)*10)+gr(3,0),(gr(5,0)*10)+gr(4,0),32);
    sp();
    return 18;
}
private int _147(){
    sp();

    if((gr(2,6))!=0)return 148;else return 23;
}
private int _148(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(3,6));
    gw(3,7,td(gr(4,6)*gr(2,3),gr(2,6)));
    return 73;
}
private int _149(){
    sp();

    if((gr(1,6))!=0)return 150;else return 23;
}
private int _150(){
    gw(7,7,0);
    gw(1,7,gr(3,6));
    gw(2,7,gr(2,6));
    gw(3,7,td(gr(4,6)*gr(2,3),gr(1,6)));
    return 73;
}
private int _151(){
    sp();

    if((gr(4,6))!=0)return 152;else return 23;
}
private int _152(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6));
    gw(3,7,td(gr(3,6)*gr(2,3),gr(4,6)));
    return 73;
}
private int _153(){
    sp();

    if((gr(2,6))!=0)return 154;else return 23;
}
private int _154(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(4,6));
    gw(3,7,td(gr(3,6)*gr(2,3),gr(2,6)));
    return 73;
}
private int _155(){
    sp();

    if((gr(1,6))!=0)return 156;else return 23;
}
private int _156(){
    gw(7,7,0);
    gw(1,7,gr(4,6));
    gw(2,7,gr(2,6));
    gw(3,7,td(gr(3,6)*gr(2,3),gr(1,6)));
    return 73;
}
private int _157(){
    sp();

    if((gr(4,6))!=0)return 158;else return 23;
}
private int _158(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,td(gr(2,6)*gr(2,3),gr(4,6)));
    gw(3,7,gr(3,6));
    return 73;
}
private int _159(){
    sp();

    if((gr(3,6))!=0)return 160;else return 23;
}
private int _160(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,td(gr(2,6)*gr(2,3),gr(3,6)));
    gw(3,7,gr(4,6));
    return 73;
}
private int _161(){
    sp();

    if((gr(1,6))!=0)return 162;else return 23;
}
private int _162(){
    gw(7,7,0);
    gw(1,7,gr(4,6));
    gw(2,7,td(gr(2,6)*gr(2,3),gr(1,6)));
    gw(3,7,gr(3,6));
    return 73;
}
private int _163(){
    sp();

    if((gr(4,6))!=0)return 164;else return 23;
}
private int _164(){
    gw(7,7,0);
    gw(1,7,td(gr(1,6)*gr(2,3),gr(4,6)));
    gw(2,7,gr(2,6));
    gw(3,7,gr(3,6));
    return 73;
}
private int _165(){
    sp();

    if((gr(3,6))!=0)return 166;else return 23;
}
private int _166(){
    gw(7,7,0);
    gw(1,7,td(gr(1,6)*gr(2,3),gr(3,6)));
    gw(2,7,gr(2,6));
    gw(3,7,gr(4,6));
    return 73;
}
private int _167(){
    sp();

    if((gr(2,6))!=0)return 168;else return 23;
}
private int _168(){
    gw(7,7,0);
    gw(1,7,td(gr(1,6)*gr(2,3),gr(2,6)));
    gw(2,7,gr(3,6));
    gw(3,7,gr(4,6));
    return 73;
}
private int _169(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6));
    gw(3,7,td(gr(4,6)*gr(3,6),gr(2,3)));
    sp();
    return 73;
}
private int _170(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(3,6));
    gw(3,7,td(gr(4,6)*gr(2,6),gr(2,3)));
    sp();
    return 73;
}
private int _171(){
    gw(7,7,0);
    gw(1,7,gr(3,6));
    gw(2,7,gr(2,6));
    gw(3,7,td(gr(4,6)*gr(1,6),gr(2,3)));
    sp();
    return 73;
}
private int _172(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6));
    gw(3,7,td(gr(3,6)*gr(4,6),gr(2,3)));
    sp();
    return 73;
}
private int _173(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(4,6));
    gw(3,7,td(gr(3,6)*gr(2,6),gr(2,3)));
    sp();
    return 73;
}
private int _174(){
    gw(7,7,0);
    gw(1,7,gr(4,6));
    gw(2,7,gr(2,6));
    gw(3,7,td(gr(3,6)*gr(1,6),gr(2,3)));
    sp();
    return 73;
}
private int _175(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,td(gr(2,6)*gr(4,6),gr(2,3)));
    gw(3,7,gr(3,6));
    sp();
    return 73;
}
private int _176(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,td(gr(2,6)*gr(3,6),gr(2,3)));
    gw(3,7,gr(4,6));
    sp();
    return 73;
}
private int _177(){
    gw(7,7,0);
    gw(1,7,gr(4,6));
    gw(2,7,td(gr(2,6)*gr(1,6),gr(2,3)));
    gw(3,7,gr(3,6));
    sp();
    return 73;
}
private int _178(){
    gw(7,7,0);
    gw(1,7,td(gr(1,6)*gr(4,6),gr(2,3)));
    gw(2,7,gr(2,6));
    gw(3,7,gr(3,6));
    sp();
    return 73;
}
private int _179(){
    gw(7,7,0);
    gw(1,7,td(gr(1,6)*gr(3,6),gr(2,3)));
    gw(2,7,gr(2,6));
    gw(3,7,gr(4,6));
    sp();
    return 73;
}
private int _180(){
    gw(7,7,0);
    gw(1,7,td(gr(1,6)*gr(2,6),gr(2,3)));
    gw(2,7,gr(3,6));
    gw(3,7,gr(4,6));
    sp();
    return 73;
}
private int _181(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(4,6)-gr(3,6));
    sp();
    return 73;
}
private int _182(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(3,6));
    gw(3,7,gr(4,6)-gr(2,6));
    sp();
    return 73;
}
private int _183(){
    gw(7,7,0);
    gw(1,7,gr(3,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(4,6)-gr(1,6));
    sp();
    return 73;
}
private int _184(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(3,6)-gr(4,6));
    sp();
    return 73;
}
private int _185(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(4,6));
    gw(3,7,gr(3,6)-gr(2,6));
    sp();
    return 73;
}
private int _186(){
    gw(7,7,0);
    gw(1,7,gr(4,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(3,6)-gr(1,6));
    sp();
    return 73;
}
private int _187(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6)-gr(4,6));
    gw(3,7,gr(3,6));
    sp();
    return 73;
}
private int _188(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6)-gr(3,6));
    gw(3,7,gr(4,6));
    sp();
    return 73;
}
private int _189(){
    gw(7,7,0);
    gw(1,7,gr(4,6));
    gw(2,7,gr(2,6)-gr(1,6));
    gw(3,7,gr(3,6));
    sp();
    return 73;
}
private int _190(){
    gw(7,7,0);
    gw(1,7,gr(1,6)-gr(4,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(3,6));
    sp();
    return 73;
}
private int _191(){
    gw(7,7,0);
    gw(1,7,gr(1,6)-gr(3,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(4,6));
    sp();
    return 73;
}
private int _192(){
    gw(7,7,0);
    gw(1,7,gr(1,6)-gr(2,6));
    gw(2,7,gr(3,6));
    gw(3,7,gr(4,6));
    sp();
    return 73;
}
private int _193(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(4,6)+gr(3,6));
    sp();
    return 73;
}
private int _194(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(3,6));
    gw(3,7,gr(4,6)+gr(2,6));
    sp();
    return 73;
}
private int _195(){
    gw(7,7,0);
    gw(1,7,gr(3,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(4,6)+gr(1,6));
    sp();
    return 73;
}
private int _196(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(3,6)+gr(4,6));
    sp();
    return 73;
}
private int _197(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(4,6));
    gw(3,7,gr(3,6)+gr(2,6));
    sp();
    return 73;
}
private int _198(){
    gw(7,7,0);
    gw(1,7,gr(4,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(3,6)+gr(1,6));
    sp();
    return 73;
}
private int _199(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6)+gr(4,6));
    gw(3,7,gr(3,6));
    sp();
    return 73;
}
private int _200(){
    gw(7,7,0);
    gw(1,7,gr(1,6));
    gw(2,7,gr(2,6)+gr(3,6));
    gw(3,7,gr(4,6));
    sp();
    return 73;
}
private int _201(){
    gw(7,7,0);
    gw(1,7,gr(4,6));
    gw(2,7,gr(2,6)+gr(1,6));
    gw(3,7,gr(3,6));
    sp();
    return 73;
}
private int _202(){
    gw(7,7,0);
    gw(1,7,gr(1,6)+gr(4,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(3,6));
    sp();
    return 73;
}
private int _203(){
    gw(7,7,0);
    gw(1,7,gr(1,6)+gr(3,6));
    gw(2,7,gr(2,6));
    gw(3,7,gr(4,6));
    sp();
    return 73;
}
private int _204(){
    gw(7,7,0);
    gw(1,7,gr(1,6)+gr(2,6));
    gw(2,7,gr(3,6));
    gw(3,7,gr(4,6));
    sp();
    return 73;
}
private int _205(){
    sa(sp()-1L);

    sa(sr());
    sa(32);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((sr()%100)+9);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/100L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 1;
}

public void main(){
    int c=0;
    while(c<206){
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
    case 116:c=_116();break;
    case 117:c=_117();break;
    case 118:c=_118();break;
    case 119:c=_119();break;
    case 120:c=_120();break;
    case 121:c=_121();break;
    case 122:c=_122();break;
    case 123:c=_123();break;
    case 124:c=_124();break;
    case 125:c=_125();break;
    case 126:c=_126();break;
    case 127:c=_127();break;
    case 128:c=_128();break;
    case 129:c=_129();break;
    case 130:c=_130();break;
    case 131:c=_131();break;
    case 132:c=_132();break;
    case 133:c=_133();break;
    case 134:c=_134();break;
    case 135:c=_135();break;
    case 136:c=_136();break;
    case 137:c=_137();break;
    case 138:c=_138();break;
    case 139:c=_139();break;
    case 140:c=_140();break;
    case 141:c=_141();break;
    case 142:c=_142();break;
    case 143:c=_143();break;
    case 144:c=_144();break;
    case 145:c=_145();break;
    case 146:c=_146();break;
    case 147:c=_147();break;
    case 148:c=_148();break;
    case 149:c=_149();break;
    case 150:c=_150();break;
    case 151:c=_151();break;
    case 152:c=_152();break;
    case 153:c=_153();break;
    case 154:c=_154();break;
    case 155:c=_155();break;
    case 156:c=_156();break;
    case 157:c=_157();break;
    case 158:c=_158();break;
    case 159:c=_159();break;
    case 160:c=_160();break;
    case 161:c=_161();break;
    case 162:c=_162();break;
    case 163:c=_163();break;
    case 164:c=_164();break;
    case 165:c=_165();break;
    case 166:c=_166();break;
    case 167:c=_167();break;
    case 168:c=_168();break;
    case 169:c=_169();break;
    case 170:c=_170();break;
    case 171:c=_171();break;
    case 172:c=_172();break;
    case 173:c=_173();break;
    case 174:c=_174();break;
    case 175:c=_175();break;
    case 176:c=_176();break;
    case 177:c=_177();break;
    case 178:c=_178();break;
    case 179:c=_179();break;
    case 180:c=_180();break;
    case 181:c=_181();break;
    case 182:c=_182();break;
    case 183:c=_183();break;
    case 184:c=_184();break;
    case 185:c=_185();break;
    case 186:c=_186();break;
    case 187:c=_187();break;
    case 188:c=_188();break;
    case 189:c=_189();break;
    case 190:c=_190();break;
    case 191:c=_191();break;
    case 192:c=_192();break;
    case 193:c=_193();break;
    case 194:c=_194();break;
    case 195:c=_195();break;
    case 196:c=_196();break;
    case 197:c=_197();break;
    case 198:c=_198();break;
    case 199:c=_199();break;
    case 200:c=_200();break;
    case 201:c=_201();break;
    case 202:c=_202();break;
    case 203:c=_203();break;
    case 204:c=_204();break;
    case 205:c=_205();break;
}
}
}
public static void main(String[]a){new Program().main();}
}
