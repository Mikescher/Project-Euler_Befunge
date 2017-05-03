/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABADNkDtvxCAMgP8KSegSmivOY6iFrFs6V8qMckNVsTIx8eNrSKqQi3Tq1PYbjJ/4EZpvxP8mHAYNfz3OEbNez8M4GXG+aDGtAlPUHdYw57WMuCf43mrc"+
                                 "/RR2uXlkMoJ1PZ7LS6j+/KjbATz1IwsNHRAO4FqLI7iuWW6SLGjPAUs4TerJsnjBHADt2GgVxxFUcrHHJjXcZEomIaDDyG1yKUbC3lWRwPY+f1NFQTkvpVEq466s8yyQ"+
                                 "mg/Z4vHiwy1Wlh/k3GHL60iSuP0hm12umKA25OOL/iZSUn6pcGl67Sors7EIumTlmuVzQtTz+zy/1eYL/qbl3PYDAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1014];for(int i=0;i<1014;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<169&&y<6)?g[(int)(y*169+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<169&&y<6)g[(int)(y*169+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
private int _0(){
    gw(3,1,9999);
    gw(4,1,2);
    return 1;
}
private int _1(){
    sa(-1);
    sa(gr(3,1));
    sa(1);
    sa(1-gr(4,1));
    return 2;
}
private int _2(){
    if(sp()!=0)return 30;else return 3;
}
private int _3(){
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 4;
}
private int _4(){
    gw(1,0,sp());
    sa(-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 5;
}
private int _5(){
    sa(tm(sr(),10));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),10));

    sa(sr());
    return 6;
}
private int _6(){
    if(sp()!=0)return 5;else return 7;
}
private int _7(){
    sp();
    return 8;
}
private int _8(){
    sa(sp()+(gr(1,0)*10));

    gw(1,0,sp());
    return 9;
}
private int _9(){
    if((sr()+1)!=0)return 8;else return 10;
}
private int _10(){
    sp();
    sa(gr(1,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if((sr()+1)!=0)return 4;else return 11;
}
private int _11(){
    sp();
    sa(sr());
    sa(9);
    return 12;
}
private int _12(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr());
    return 13;
}
private int _13(){
    if(sp()!=0)return 12;else return 14;
}
private int _14(){
    sp();
    sa(sr());
    return 15;
}
private int _15(){
    sa(tm(sr(),10));
    sa(sr());

    if(sp()!=0)return 16;else return 28;
}
private int _16(){
    sa(sr());
    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 17;else return 28;
}
private int _17(){
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(td(sp(),10));

    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 18;else return 15;
}
private int _18(){
    sp();
    sa(9);
    return 19;
}
private int _19(){
    sa(sr());
    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()-1L);

    sa(sr());
    return 20;
}
private int _20(){
    if(sp()!=0)return 19;else return 21;
}
private int _21(){
    sp();
    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()-9L);

    sa((sp()!=0)?0:1);
    return 22;
}
private int _22(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sp();

    if(sp()!=0)return 27;else return 23;
}
private int _23(){
    sp();
    sa(gr(4,1)-1);
    gw(4,1,gr(4,1)-1);
    sa(sp()-1L);


    if(sp()!=0)return 1;else return 24;
}
private int _24(){
    sa(gr(3,1)-1);
    gw(3,1,gr(3,1)-1);

    if(sp()!=0)return 26;else return 25;
}
private int _25(){
    System.out.print("RORRE");
    return 31;
}
private int _26(){
    gw(4,1,5);
    return 1;
}
private int _27(){
    System.out.print(String.valueOf((long)(sp())));
    return 31;
}
private int _28(){
    sp();
    return 29;
}
private int _29(){
    sp();
    sa(0);
    return 22;
}
private int _30(){
    sa(sp()+1L);

    sa(sr()*gr(3,1));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr()-gr(4,1));
    return 2;
}

public void main(){
    int c=0;
    while(c<31){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
