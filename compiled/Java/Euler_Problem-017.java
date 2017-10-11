/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABACVkEFuwyAQRa8yBmcDcgOGAYoQ6kGQ3UUlb7Ni5dy92E5lEiVWMxvg8/7MhwzvlVAKtVaIWhnjnLWfzplD3hhEtOYIqqp9M8/C505WSoBHKVS3ETWL"+
                                 "3ns5EUG6JC90GG9Sv0n9Za74/GIuYz2SHwIC2jb8g39R4dGyNosekZ/7KZXldN/c3/sLqdn3HjiWTGc5WfHHR5Gib2gefblJhRzEJMNiLOdTM1et1zR5z7X1J1fiWFd+"+
                                 "qVVO5NVWBiRY7Bs8HD/vtksq2WUup5A8hZHvVALZPff7+ble1dcHH4E2QH0CysMve1WrzNACAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[720];for(int i=0;i<720;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<48&&y<15)?g[(int)(y*48+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<48&&y<15)g[(int)(y*48+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(20,1,gr(20,1)-48);
    sa(19);
    return 1;
}
private int _1(){
    sa(sr());
    sa(sr());
    sa(sr());
    sa(1);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}

    if(sp()!=0)return 24;else return 2;
}
private int _2(){
    gw(20,2,gr(20,2)-48);
    sa(19);
    return 3;
}
private int _3(){
    sa(sr());
    sa(sr());
    sa(sr());
    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}

    if(sp()!=0)return 23;else return 4;
}
private int _4(){
    sp();
    sp();
    sa(0);
    sa(1000);
    sa(0);
    sa(1000);
    return 5;
}
private int _5(){
    if(sr()<100)return 6;else return 18;
}
private int _6(){
    if(sr()>20)return 17;else return 7;
}
private int _7(){
    sa(1);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()+0L);
    return 8;
}
private int _8(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 16;else return 9;
}
private int _9(){
    sa(sp()+sp());

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 13;else return 10;
}
private int _10(){
    sa(sp()+sp());

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 12;else return 11;
}
private int _11(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 10;
}
private int _12(){
    sa(sp()+sp());

    t0=sp();
    System.out.print(String.valueOf(t0)+" ");
    return 25;
}
private int _13(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    return 14;
}
private int _14(){
    if(sp()!=0)return 15;else return 5;
}
private int _15(){
    sa(sp()+sp());
    return 8;
}
private int _16(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+sp());
    return 8;
}
private int _17(){
    sa(td(sr(),10));
    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),10));

    sa(sr());
    sa((sp()!=0)?0:1);
    return 14;
}
private int _18(){
    if(sr()!=1000)return 20;else return 19;
}
private int _19(){
    sp();
    sa(3);
    sa(8);
    return 8;
}
private int _20(){
    if(tm(sr(),100)==0)return 22;else return 21;
}
private int _21(){
    sa(td(sr(),100));
    sa(1);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(tm(sp(),100));

    sa(7);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(3);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    sa((sp()!=0)?0:1);
    return 14;
}
private int _22(){
    sa(td(sp(),100));

    sa(1);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(7);
    return 8;
}
private int _23(){
    sa(sp()-1L);
    return 3;
}
private int _24(){
    sa(sp()-1L);
    return 1;
}

public void main(){
    int c=0;
    while(c<25){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
