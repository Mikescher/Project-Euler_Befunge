/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtkbFuxCAMhl/FASKdQGkMEbrGilC3vkCHq4SSbqxMTNd3r7ksvUo5tRJjPWAJ7N/fbwooBW8gQbYJ2KOh3uXSVq81379eA712UX5Rk62eJ/EuIKPx"+
                                 "3oJaDksDiFfxrGlyWXy600lorZ3L6DDjhJkL7EAYiav62UROY6bu+hfWzGrGUkJ3JrWsd9PrfoqEYz4IziUKzJc+ZNnoO0iiTq4bsdGhq292uHFVzUrNFs4xeUyRDtYW"+
                                 "MAby3vSkIxBLKGVtCRMmawDYfvCYlcNE14qfR54azdxz+kkcpt3xOvLGE3qT0S8Q1AvA7nhvKJYIBvvgQ26xbiu74IMXhBKShCcJSkK9vWtdQONDrS/WbUIrAAUAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1280];for(int i=0;i<1280;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<16)?g[(int)(y*80+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<16)g[(int)(y*80+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
private int _0(){
    gw(3,2,568);
    gw(2,2,10000000);
    gw(2,0,0);
    gw(3,0,0);
    gw(79,7,0);
    sa(566);
    return 1;
}
private int _1(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),71))+9);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),71));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 2;else return 20;
}
private int _2(){
    gw(10,0,1);
    gw(27,1,89);
    sp();
    sa(gr(2,2));
    sa(gr(2,2));
    sa(gr(2,2)>gr(3,2)?1:0);
    return 3;
}
private int _3(){
    if(sp()!=0)return 6;else return 4;
}
private int _4(){
    sa(sr());
    sa((tm(sr(),71))+9);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),71));

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 5;else return 11;
}
private int _5(){
    sp();
    sa(sr());
    sa(7);
    sa(gr(2,0));
    gw(2,0,gr(2,0)+1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 6;
}
private int _6(){
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sr(),10));
    sa(sr());
    sa(sp()*sp());

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 7;
}
private int _7(){
    if(sp()!=0)return 10;else return 8;
}
private int _8(){
    sp();
    sp();
    return 9;
}
private int _9(){
    sa(sr()>gr(3,2)?1:0);
    return 3;
}
private int _10(){
    gw(5,0,sp());
    sa(sp()+sp());

    sa((tm(td(gr(5,0),10),10))*(tm(td(gr(5,0),10),10)));
    sa(td(gr(5,0),10));
    sa(td(gr(5,0),10));
    return 7;
}
private int _11(){
    if(sr()-89==0)return 12;else return 18;
}
private int _12(){
    gw(3,0,gr(3,0)+1);
    return 13;
}
private int _13(){
    gw(5,0,sp());
    sp();
    sa(gr(2,0));

    if((gr(2,0))!=0)return 16;else return 14;
}
private int _14(){
    sp();
    sa(sp()-1L);

    sa(sr());
    sa(sr());

    if(sp()!=0)return 9;else return 15;
}
private int _15()throws java.io.IOException{
    System.out.print(String.valueOf(gr(3,0)));
    sp();
    sp();
    return 21;
}
private int _16(){
    sa(sp()-1L);

    sa(sr());
    gw(2,0,sp());
    sa(7);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(gr(sp(),v0));}
    sa(gr(5,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),71))+9);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),71));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(gr(2,0));
    return 17;
}
private int _17(){
    if((gr(2,0))!=0)return 16;else return 14;
}
private int _18(){
    if(sr()!=1)return 19;else return 13;
}
private int _19(){
    sp();
    return 6;
}
private int _20(){
    sa(sp()-1L);
    return 1;
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
