/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtU8uO2zAM/BVGdi7Sak3KseM1VKMfYjgB2kJXnXxq/71DO8kmu8kCRXvrEpBEvUbDITWXJVFRFOT/0hYQ2D/Ho/8Ljz7xPvH+EG+1+TAXm9cpZnTf"+
                                 "oqxj4lCW8e1uUZyQhWaizCGxLMjFekP9Po/uZWu7DgsU+cE7agOutWjCGbPQddZS4DwETuLhCKdBfM9jsFjCduWmicrImWsniWvKzoJCqPS1eM2P6YLCNdogrofZ0YdK"+
                                 "N5x1vfllOjsei+nQmx/fjFWvXt7ZvriapxuqJybNmNG3S79HX8wHfHIW3+IRkayyPLT5Vc/yMEGpe/q/ESxe9RhvcjK0Igmx6JBXP+RmGessIUE/vwFDqZM5kHFH+Hus"+
                                 "JwSKNQRKiHT1KgnzFHMSaZwCSKN+6+VdAuMMsb0sJ9c8rxM0BJV2kneSNC9R8RRkj1TKcuiuLPZSi2WceQU9r6CImq35bgD7rhgf2VCpFuJTsC7h7lZ2OlTeatxaFdg+"+
                                 "bn7SKV4+RwqWTlnmFGR/n+sHFlFyeLB/dk3jngKAXB9Ei9hDd0NfiMwT7PnrNVeVvuUz1cqD4qWEJk1ouxQ3nLPa6uILSPjoa90SO9lvqywlwdAHAAA=";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[2000];for(int i=0;i<2000;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<25)?g[(int)(y*80+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<25)g[(int)(y*80+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
private int _0(){
    gw(1,0,6);
    gw(2,0,128);
    return 1;
}
private int _1(){
    gw(2,0,gr(2,0)-1);
    sa(gr(1,0)-1);
    gw((tm(gr(2,0),64))+9,((gr(1,0)-1)*2)+(td(gr(2,0),64)),0);
    return 2;
}
private int _2(){
    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 3;else return 33;
}
private int _3(){
    sp();

    if((gr(2,0))==0)return 4;else return 1;
}
private int _4(){
    gw(2,0,gr(1,0));
    return 5;
}
private int _5(){
    gw(2,0,gr(2,0)-1);
    gw(3,0,0);
    sa(1);
    sa(1+(0*(gr(2,0)+1)));
    sa((1+(0*(gr(2,0)+1)))<1000?1:0);
    return 6;
}
private int _6(){
    if(sp()!=0)return 7;else return 9;
}
private int _7(){
    sp();
    return 8;
}
private int _8(){
    sa(sp()+1L);

    sa(sr());
    sa(sr());
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(t0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(sp()-v0);}

    t1=sp();
    t1/=2;
    t1*=gr(2,0)+1;
    sa(sp()+t1);

    sa(sr()<1000?1:0);
    return 6;
}
private int _9(){
    if(sr()>9999)return 10;else return 32;
}
private int _10(){
    sp();
    sp();

    if((gr(2,0))==0)return 11;else return 5;
}
private int _11(){
    sa(gr(1,0)-1);
    gw(5,gr(1,0)-1,0);
    return 12;
}
private int _12(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(6);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(7);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());

    if(sp()!=0)return 13;else return 31;
}
private int _13(){
    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 15;else return 14;
}
private int _14(){
    sa(sp()-1L);

    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(5);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 12;
}
private int _15(){
    gw(6,gr(1,1),gr(6,gr(1,1))+1);
    gw(1,2,gr(6,gr(1,1)));
    gw(1,3,gr(5,gr(1,1)));
    sp();
    return 16;
}
private int _16(){
    if(gr(1,2)-gr(1,0)==0)return 17;else return 18;
}
private int _17(){
    gw(6,gr(1,1),-1);
    gw(5,gr(1,1),gr(5,gr(1,1))+1);
    gw(6,gr(1,1),gr(6,gr(1,1))+1);
    gw(1,2,gr(6,gr(1,1)));
    gw(1,3,gr(5,gr(1,1)));
    return 16;
}
private int _18(){
    if(gr(1,3)>127)return 19;else return 20;
}
private int _19(){
    gw(1,1,gr(1,1)-1);
    gw(7,gr(6,gr(1,1)),0);
    gw(6,gr(1,1),gr(6,gr(1,1))+1);
    gw(1,2,gr(6,gr(1,1)));
    gw(1,3,gr(5,gr(1,1)));
    return 16;
}
private int _20(){
    if((gr(7,gr(1,2)))!=0)return 22;else return 21;
}
private int _21(){
    gw(1,4,gr((tm(gr(1,3),64))+9,(td(gr(1,3),64))+(gr(1,2)*2)));

    if((gr(1,4))!=0)return 23;else return 22;
}
private int _22(){
    sa(0);
    return 15;
}
private int _23(){
    if((gr(1,1)*((tm(gr((tm(gr(5,gr(1,1)-1),64))+9,(td(gr(5,gr(1,1)-1),64))+(gr(6,gr(1,1)-1)*2)),100))-(td(gr(1,4),100))))!=0)return 22;else return 24;
}
private int _24(){
    if((gr(1,0)-1)<=gr(1,1))return 26;else return 25;
}
private int _25(){
    gw(7,gr(1,2),1);
    gw(1,1,gr(1,1)+1);
    gw(6,gr(1,1),-1);
    gw(5,gr(1,1),0);
    gw(6,gr(1,1),gr(6,gr(1,1))+1);
    gw(1,2,gr(6,gr(1,1)));
    gw(1,3,gr(5,gr(1,1)));
    return 16;
}
private int _26(){
    if((tm(gr(1,4),100))!=(td(gr((tm(gr(5,0),64))+9,(td(gr(5,0),64))+(gr(6,0)*2)),100)))return 22;else return 27;
}
private int _27(){
    gw(2,1,0);
    t2=0;
    return 28;
}
private int _28(){
    t0=gr((tm(gr(5,gr(2,1)),64))+9,(td(gr(5,gr(2,1)),64))+(gr(6,gr(2,1))*2));
    System.out.print(String.valueOf(gr((tm(gr(5,gr(2,1)),64))+9,(td(gr(5,gr(2,1)),64))+(gr(6,gr(2,1))*2)))+" ");
    System.out.print('\n');
    t2+=t0;
    t0=gr(2,1)+1;
    gw(2,1,gr(2,1)+1);
    t0-=gr(1,0);
    return 29;
}
private int _29(){
    if((t0)!=0)return 28;else return 30;
}
private int _30(){
    System.out.print("  = ");
    System.out.print(String.valueOf(t2)+" ");
    return 34;
}
private int _31(){
    gw(6,0,-1);
    gw(1,1,0);
    sp();
    return 22;
}
private int _32(){
    gw((tm(gr(3,0),64))+9,(td(gr(3,0),64))+(gr(2,0)*2),sp());
    gw(3,0,gr(3,0)+1);
    return 8;
}
private int _33(){
    sa(sp()-1L);

    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*2L);

    sa(sp()+(td(gr(2,0),64)));

    sa((tm(gr(2,0),64))+9);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 2;
}

public void main(){
    int c=0;
    while(c<34){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
