/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABAClks1yhCAMx18FcG8MFvxYjeMwfYO97qGj3rhy4rQPvwkq2g720GYGiJL880s0MPZktIpk7Moo8JEsF2HFIAKe4VKDsZGNIR4Y5o0EJbRwWoLX9aCM"+
                                 "07V4iDXOgsaX2ttaO5DaGTWsnscUNXR4+7W8YjFMm6eCpyIKRRyKO93F52K82aEIc6ddu/wCZ19BmZEk51DwBWXhlm0iqkUXJUHxXBCbWFRbJ/MUFCmNxxlhG0ZiM56a"+
                                 "mfA2qoHGJsHQVuEmZWv8SX1TszFCfAjFoE8e7F7Y1ACfcUqYn+93UwsKs3D8HbDNuyevB/pKGxsRQU1bs7E5xfmKJw+2eyJqktf+k61ORFXymjMblYpVYvlLtioRHRPU"+
                                 "f2Q77JOVZflz7WwRCDra+gwaqfUwZgt9N0sSsP8fu84JlsdO3+lgHQ7PAwAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[975];for(int i=0;i<975;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<39&&y<25)?g[(int)(y*39+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<39&&y<25)g[(int)(y*39+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2,t3,t4,t5,t6,t7,t8,t9,t10,t11,t12,t13;
private int _0(){
    gw(9,0,58);
    gw(3,0,0);
    return 1;
}
private int _1(){
    sa(gr(gr(3,0)+9,0)-1);
    gw(gr(3,0)+9,0,gr(gr(3,0)+9,0)-1);
    sa(sp()-48L);

    sa(sr());
    gw(7,0,sp());
    sa((sp()<0)?1:0);


    if(sp()!=0)return 2;else return 3;
}
private int _2(){
    sa(79);
    sa(gr(3,0)-1);
    gw(3,0,gr(3,0)-1);
    sa(sp()+9L);

    sa(0);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);

    sa(sp()+9L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 1;
}
private int _3(){
    if(gr(gr(7,0)+9,1)-79==0)return 4;else return 1;
}
private int _4(){
    sa(gr(3,0));

    if((gr(3,0))!=0)return 5;else return 25;
}
private int _5(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 6;else return 24;
}
private int _6(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 7;else return 23;
}
private int _7(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 8;else return 20;
}
private int _8(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 9;else return 22;
}
private int _9(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 10;else return 20;
}
private int _10(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 11;else return 21;
}
private int _11(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 12;else return 20;
}
private int _12(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 19;else return 13;
}
private int _13(){
    sa((((gr(15,0)+gr(16,0)+gr(17,0))-gr(5,1)!=0)?1:0)+((gr(7,0)-9!=0)?0L:1L));
    return 14;
}
private int _14(){
    if(sp()!=0)return 18;else return 15;
}
private int _15(){
    sp();

    if(9<=gr(3,0))return 17;else return 16;
}
private int _16(){
    gw(gr(7,0)+9,1,88);
    sa(58);
    sa(gr(3,0)+1);
    gw(3,0,gr(3,0)+1);
    sa(sp()+9L);

    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 1;
}
private int _17(){
    t0=gr(10,0)-47;
    t1=gr(17,0)-47;
    t2=gr(18,0)-47;
    t3=gr(17,0)-47;
    t4=gr(15,0)-47;
    t5=gr(16,0)-47;
    t6=gr(15,0)-47;
    t7=gr(13,0)-47;
    t8=gr(14,0)-47;
    t9=gr(13,0)-47;
    t10=gr(11,0)-47;
    t11=gr(12,0)-47;
    t12=gr(11,0)-47;
    t13=gr(10,0)-47;
    System.out.print(String.valueOf(gr(9,0)-47)+" ");
    System.out.print(String.valueOf(t13)+" ");
    System.out.print(String.valueOf(t12)+" ");
    System.out.print(String.valueOf(t11)+" ");
    System.out.print(String.valueOf(t10)+" ");
    System.out.print(String.valueOf(t9)+" ");
    System.out.print(String.valueOf(t8)+" ");
    System.out.print(String.valueOf(t7)+" ");
    System.out.print(String.valueOf(t6)+" ");
    System.out.print(String.valueOf(t5)+" ");
    System.out.print(String.valueOf(t4)+" ");
    System.out.print(String.valueOf(t3)+" ");
    System.out.print(String.valueOf(t2)+" ");
    System.out.print(String.valueOf(t1)+" ");
    System.out.print(String.valueOf(t0)+" ");
    return 26;
}
private int _18(){
    sp();
    return 1;
}
private int _19(){
    sa((((gr(17,0)+gr(18,0)+gr(10,0))-gr(5,1)!=0)?1:0)+((gr(9,0)-48)>gr(7,0)?1L:0L));
    return 14;
}
private int _20(){
    sa((gr(9,0)-48)>gr(7,0)?1:0);
    return 14;
}
private int _21(){
    sa((((gr(13,0)+gr(14,0)+gr(15,0))-gr(5,1)!=0)?1:0)+((gr(7,0)-9!=0)?0L:1L));
    return 14;
}
private int _22(){
    sa((((gr(11,0)+gr(12,0)+gr(13,0))-gr(5,1)!=0)?1:0)+((gr(7,0)-9!=0)?0L:1L));
    return 14;
}
private int _23(){
    gw(5,1,gr(9,0)+gr(10,0)+gr(11,0));
    sa((gr(7,0)-9!=0)?0:1);
    return 14;
}
private int _24(){
    sa((gr(7,0)-9!=0)?0:1);
    return 14;
}
private int _25(){
    sa(gr(7,0)>5?1:0);
    return 14;
}

public void main(){
    int c=0;
    while(c<26){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
