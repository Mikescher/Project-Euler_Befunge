/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABACNVMuO6yAM/RUmJJsibsHNqwh55g/6A1E60l2wzYpV7r9fmzTNoxl1rKhKiX045hyT/c0MDGIXUaCBYJVz/BGKDxnvVfq9WBjQpm/0Bs1J86oBGCKK"+
                                 "KDcxo6Eco9SnNvuXBTCeVvLVXv1+cy/QSjMKcbvdRHputCqX/C9JkPM/yQVT2VH4/t5LbzGKY26/C4TUMXV50R89ULW1xhgrP1MsaPgbtH3HXlhjj9AYr49QiiGAVU2n"+
                                 "MpMVqqoClA6ld1MOC0CKTREUcSOsQzQGDFWlziWJuKM0agIPtI8T2voBSpKqZnKp0R/QlvoVwwDgHmJIlDla7RpFlokhCGHsrlNsIbR65OyvtwdX+9F1iajwGTDartPJ"+
                                 "WNhA+LM5ZcxfwTCXng7jRAeqopnQ1p3GAa7UywCtJeB7lOL7DAEqR44qOnrxIvJqASSEjwln+vGZJjRu9ZXbI9xCjYmSn3vJkl6KpCROYPGZkST9EQ1BVxA6mtD+XivX"+
                                 "u2aA6j7PBm9Ao+qWCUmSLmh4ZXtfaYYf31NfM1OmVQL7pqCTV11DmaFUQwkP1+0ma9R0bFfaDGu6RNhqVmi6LUKgclL6xf5ktjO7+nCCMeWnmpwTYp2v8tARlw2rHXpc"+
                                 "68ZibYTzOLmTSyNG8S7aDXQisBLOidmdSnhVvUUDov8ULu6FU2Tap6P692hIErbzVb71e8/Pyp/q+K5cx3+VQY0mGAYAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1560];for(int i=0;i<1560;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<78&&y<20)?g[(int)(y*78+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<78&&y<20)g[(int)(y*78+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(0,2,99);
    return 1;
}
private int _1(){
    if(gr(0,2)!=1000)return 2;else return 47;
}
private int _2(){
    t0=gr(0,2)+1;
    t1=gr(0,2)+1;
    gw(0,2,gr(0,2)+1);
    t1%=2;
    t1=(t1!=0)?0:1;

    if((t1)!=0)return 1;else return 3;
}
private int _3(){
    t0%=5;
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 1;else return 4;
}
private int _4(){
    gw(1,2,3);
    return 5;
}
private int _5(){
    t0=gr(1,2)+1;
    gw(1,2,gr(1,2)+1);
    t0-=14;
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 1;else return 6;
}
private int _6(){
    gw(2,2,0);

    if(((gr(0,gr(1,2))-48)+gr(2,2))!=0)return 8;else return 7;
}
private int _7(){
    t0=gr(2,2)+1;
    gw(2,2,gr(2,2)+1);
    t0-=3;
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 5;else return 8;
}
private int _8(){
    gw(4,2,gr(0,2));
    sa(5);
    sa(gr(5,gr(1,2))-48);
    return 9;
}
private int _9(){
    if(sp()!=0)return 10;else return 46;
}
private int _10(){
    sa(sr());
    sa((tm(gr(4,2),10))+48);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+7L);

    sa(gr(1,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    gw(4,2,td(gr(4,2),10));
    return 11;
}
private int _11(){
    sa(sr());
    sa((sp()!=0)?0:1);

    if(sp()!=0)return 12;else return 45;
}
private int _12(){
    sp();
    sa(gr(12,gr(1,2))-48);
    sa(4);
    return 13;
}
private int _13(){
    sa(sr()+7);
    sa(gr(1,2));
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 44;else return 14;
}
private int _14(){
    sp();
    sa(sp()*10L);

    sa(sp()+sp());

    sa(sp()*10L);

    sa(sp()+sp());

    sa(sp()*10L);

    sa(sp()+sp());

    sa(sp()*10L);

    sa(sp()+sp());

    sa(sp()*10L);

    sa(sp()+sp());

    sa(sr());
    gw(7,2,sp());

    if(tm(sr(),2)!=0)return 16;else return 15;
}
private int _15(){
    sp();
    return 7;
}
private int _16(){
    if(tm(sr(),3)!=0)return 17;else return 15;
}
private int _17(){
    gw(5,2,sp());
    sa(7);
    sa(tm(gr(5,2),7));
    return 18;
}
private int _18(){
    if(sp()!=0)return 19;else return 15;
}
private int _19(){
    if(sr()>(td(gr(5,2),2)))return 22;else return 20;
}
private int _20(){
    sa(sr()-2);
    sa(gr(5,2));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(tm(sp(),v0));}

    sa((sp()!=0)?0:1);

    if(sp()!=0)return 15;else return 21;
}
private int _21(){
    sa(sp()+6L);

    sa(sr());
    sa(gr(5,2));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(tm(sp(),v0));}
    return 18;
}
private int _22(){
    gw(8,2,1);
    gw(9,2,gr(2,2));
    gw(9,2,gr(9,2)+1);
    gw(4,2,gr(0,2));
    sp();
    return 23;
}
private int _23(){
    sa(5);
    sa(gr(5,gr(1,2))-48);
    return 24;
}
private int _24(){
    if(sp()!=0)return 25;else return 43;
}
private int _25(){
    sa(sr());
    sa((tm(gr(4,2),10))+48);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+7L);

    sa(gr(9,2)+4);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    gw(4,2,td(gr(4,2),10));
    return 26;
}
private int _26(){
    sa(sr());

    if(sp()!=0)return 42;else return 27;
}
private int _27(){
    sp();
    sa(gr(12,gr(9,2)+4)-48);
    sa(4);
    return 28;
}
private int _28(){
    sa(sr()+7);
    sa(gr(9,2)+4);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 41;else return 29;
}
private int _29(){
    sp();
    sa(sp()*10L);

    sa(sp()+sp());

    sa(sp()*10L);

    sa(sp()+sp());

    sa(sp()*10L);

    sa(sp()+sp());

    sa(sp()*10L);

    sa(sp()+sp());

    sa(sp()*10L);

    sa(sp()+sp());


    if(tm(sr(),2)!=0)return 34;else return 30;
}
private int _30(){
    sp();

    if(gr(9,2)!=9)return 31;else return 32;
}
private int _31(){
    gw(9,2,gr(9,2)+1);
    gw(4,2,gr(0,2));
    return 23;
}
private int _32(){
    if(gr(8,2)!=8)return 7;else return 33;
}
private int _33(){
    System.out.print(String.valueOf(gr(7,2))+" ");
    return 48;
}
private int _34(){
    if(tm(sr(),3)!=0)return 35;else return 30;
}
private int _35(){
    gw(5,2,sp());
    sa(7);
    sa(tm(gr(5,2),7));
    return 36;
}
private int _36(){
    if(sp()!=0)return 37;else return 30;
}
private int _37(){
    if(sr()>(td(gr(5,2),2)))return 40;else return 38;
}
private int _38(){
    sa(sr()-2);
    sa(gr(5,2));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(tm(sp(),v0));}

    sa((sp()!=0)?0:1);

    if(sp()!=0)return 30;else return 39;
}
private int _39(){
    sa(sp()+6L);

    sa(sr());
    sa(gr(5,2));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    {long v0=sp();sa(tm(sp(),v0));}
    return 36;
}
private int _40(){
    gw(8,2,gr(8,2)+1);
    return 30;
}
private int _41(){
    sa(sp()-1L);
    return 28;
}
private int _42(){
    sa(sp()-1L);

    sa(sr());
    sa(gr(1,2));
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);
    return 24;
}
private int _43(){
    sa(sr());
    sa(gr(9,2)+48);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+7L);

    sa(gr(9,2)+4);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 26;
}
private int _44(){
    sa(sp()-1L);
    return 13;
}
private int _45(){
    sa(sp()-1L);

    sa(sr());
    sa(gr(1,2));
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);
    return 9;
}
private int _46(){
    sa(sr());
    sa(gr(2,2)+48);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+7L);

    sa(gr(1,2));
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 11;
}
private int _47(){
    return 48;
}

public void main(){
    int c=0;
    while(c<48){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
