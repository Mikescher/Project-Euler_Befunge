/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtk01ug0AMha9CIWxs0dgj/mYUod6gF0CQ3SzrFascvm4SlAAJUdMsKoSl+dHT6I3ne9AF/7yi19bq90e/Nd9l+635LttvzXfZfmu+y/Zb812234ur"+
                                 "KgoowWDlqHbhZxgz1rpsDcpIKSdKYeCkqU838j0gu4QFoUy3erZGjnVxNTlBBGPLiQppdqXtxn1uAlY5l+Ns4LhmOcjk5vl6fHp883xVOUFBkjOUOhuwOqvCR4Vvdlfp"+
                                 "IH3PzdY6CL9CGwilJGxYmHVYMPn97ho91DbR3jMHLvFkILsArAJikh9WUHHinDMkgwzJG0Q/TPqkGWDyiC7LMHZR046f0syTabvICfEWs0wjN57sdeTa5u7yaiEbo7WY"+
                                 "6ymhst+XQkW/LzbXT59l+EQpQ3NiaEYMqwf82GcpTAj26hzDB/zGBPX/8DxleHbUj+RMiq1wT5BL4Z4gDwneq4rZG/b7t6hrU/KM+iE+S1Xr4M6bhC+3/+4XG7a30abe"+
                                 "P543GNU3DXw8oeAQAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[4320];for(int i=0;i<4320;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<54)?g[(int)(y*80+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<54)g[(int)(y*80+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(79,6,0);
    gw(79,12,0);
    gw(79,18,0);
    gw(79,24,0);
    gw(79,30,0);
    gw(79,36,0);
    sa(393);
    return 1;
}
private int _1(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79))+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79));

    sa(sp()+2L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79))+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79));

    sa(sp()+8L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79))+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79));

    sa(sp()+14L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79))+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79));

    sa(sp()+20L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79))+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79));

    sa(sp()+26L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),79))+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79));

    sa(sp()+32L);

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);
    return 2;
}
private int _2(){
    if((sr()+1)!=0)return 1;else return 3;
}
private int _3(){
    gw(79,6,1);
    gw(79,12,1);
    gw(79,30,1);
    gw(7,0,0);
    gw(8,0,6);
    gw(9,0,12);
    gw(7,1,0);
    gw(8,1,6);
    gw(9,1,12);
    gw(1,1,1);
    gw(2,1,1);
    gw(4,0,0);
    gw(1,0,0);
    gw(2,0,394);
    sp();
    sa(999);
    return 4;
}
private int _4(){
    sa(394);
    sa(gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0));
    sa(tm(gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0),10));
    sa(tm(gr(79,4+gr(7,0)+2)+(gr(79,4+gr(8,0)+2)*2)+gr(1,0),10));
    return 5;
}
private int _5(){
    if(sp()!=0)return 6;else return 7;
}
private int _6(){
    t0=395-gr(2,0);

    if((395-gr(2,0))>gr(1,1))return 20;else return 7;
}
private int _7(){
    gw((tm(gr(2,0),79))+1,(td(gr(2,0),79))+gr(9,0)+2,sp());
    sa(td(sp(),10));

    gw(1,0,sp());
    sa(sr());

    if(sp()!=0)return 19;else return 8;
}
private int _8(){
    gw(7,0,tm(gr(7,0)+6,18));
    gw(8,0,tm(gr(8,0)+6,18));
    gw(9,0,tm(gr(9,0)+6,18));
    gw(1,0,0);
    gw(2,0,394);
    sp();
    sa(394);
    sa(gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0));
    sa(tm(gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0),10));
    sa(tm(gr(79,4+gr(7,1)+20)+(gr(79,4+gr(8,1)+20)*2)+gr(1,0),10));
    return 9;
}
private int _9(){
    if(sp()!=0)return 10;else return 11;
}
private int _10(){
    t0=395-gr(2,0);

    if((395-gr(2,0))>gr(2,1))return 18;else return 11;
}
private int _11(){
    gw((tm(gr(2,0),79))+1,(td(gr(2,0),79))+gr(9,1)+20,sp());
    sa(td(sp(),10));

    gw(1,0,sp());
    sa(sr());

    if(sp()!=0)return 17;else return 12;
}
private int _12(){
    gw(7,1,tm(gr(7,1)+6,18));
    gw(8,1,tm(gr(8,1)+6,18));
    gw(9,1,tm(gr(9,1)+6,18));
    sp();

    if(gr(1,1)<=gr(2,1))return 13;else return 16;
}
private int _13(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 14;else return 15;
}
private int _14(){
    gw(1,0,0);
    gw(2,0,394);
    return 4;
}
private int _15()throws java.io.IOException{
    System.out.print(String.valueOf(gr(4,0)));
    sp();
    return 21;
}
private int _16(){
    gw(4,0,gr(4,0)+1);
    return 13;
}
private int _17(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    sa(sr());
    gw(2,0,sp());
    sa((tm(sr(),79))+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79));

    sa(sp()+gr(7,1)+20);

    {long v0=sp();t0=gr(sp(),v0);}
    sa((tm(sr(),79))+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79));

    sa(sp()+gr(8,1)+20);

    {long v0=sp();t1=gr(sp(),v0);}
    t1*=2;
    t1+=gr(1,0);
    sa(t0+t1);
    sa(tm(sr(),10));
    sa(sr());
    return 9;
}
private int _18(){
    gw(2,1,t0);
    return 11;
}
private int _19(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    sa(sr());
    gw(2,0,sp());
    sa((tm(sr(),79))+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79));

    sa(sp()+gr(7,0)+2);

    {long v0=sp();t0=gr(sp(),v0);}
    sa((tm(sr(),79))+1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),79));

    sa(sp()+gr(8,0)+2);

    {long v0=sp();t1=gr(sp(),v0);}
    t1*=2;
    t1+=gr(1,0);
    sa(t0+t1);
    sa(tm(sr(),10));
    sa(sr());
    return 5;
}
private int _20(){
    gw(1,1,t0);
    return 7;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<21){
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
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
