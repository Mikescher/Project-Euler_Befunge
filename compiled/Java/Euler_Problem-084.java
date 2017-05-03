/* transpiled with BefunCompile v1.1.0 (c) 2015 */
class Program{
private final static String _g = "AR+LCAAAAAAABACtVMFy4yAM/RXVuLMzMN4FDGnCUKWf0YOH9uarT5zcf18JO8ROsrs9rA5PSAEhPT+SAeD9Hf6XvX7TeG9ejsSCOd4XO3/T6HAsJWKcu+apCeTU6Rg2"+
                                 "JVE7PTVfX2+NlP4o8+4ejj6ygM5ErmJ0yRmNS4ulTJzj7ZGLPeicK8AcVLTnJKQrrr3uS/sjaLpglR7MtO/rxlIfN25j3TaYw74vRMwLbCgucXXVs9nNjO3tTcYyMQwi"+
                                 "TdpF5X0btSl0rG7xa73aC6DTY6ApzWjUQG5Ckc79AkrRJ3kO9IU4tuhkceriZwz+ILv5OuMDdtClHAlA1Dkp7lP5bXHV7w+2/pj3xEcefe7kyRUpSbssXsJKagYavsy+"+
                                 "ZZpNZJBxz2/a7KgbH2jm3gp7Lez4FUvh5bPlOxC3uarUIpI9vxBmlh4BdHX5NwCxFjMcBpt3/KL3KqM/AOHByYzNj4bizK8vw+YtLc2TIPquRHOYrIKIIRhlR9bIAJZW"+
                                 "BAZGGD7/yFCuuqXO8GDpYWNbUokedIidmewwgvbKQugMTFx3AL4DQqBQe7qAjNLhIwluyp2sVFVsqEl8R0lNzCwVa2H82TM4YHy7a4lLHJ5pkF9WekmMtJR7cetfTqKL"+
                                 "mQQUMV3IRFHxAtdgnW7VC17mTg8E9A9x3Wcp0/Ir/g3VSFYoBAYAAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[1540];for(int i=0;i<1540;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<77&&y<20)?g[(int)(y*77+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<77&&y<20)g[(int)(y*77+x)]=v;}
private java.io.BufferedReader ib=new java.io.BufferedReader(new java.io.InputStreamReader(System.in));
private boolean rd(){return Math.random()<0.5;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1,t2;
private int _0(){
    gw(4,0,0);
    gw(41,1,0);
    sa(1000000);
    sa(38);
    return 1;
}
private int _1(){
    sa(sr()+2);
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());

    if(sp()!=0)return 97;else return 2;
}
private int _2(){
    sp();
    return 3;
}
private int _3(){
    sa(gr(4,0));
    gw(gr(4,0)+2,1,gr(gr(4,0)+2,1)+1);
    return 4;
}
private int _4(){
    if(rd()){if(rd()){return 96;}else{return 95;}}else{if(rd()){return 94;}else{return 5;}}
}
private int _5(){
    sa(2);
    return 6;
}
private int _6(){
    if(rd()){if(rd()){return 93;}else{return 92;}}else{if(rd()){return 91;}else{return 7;}}
}
private int _7(){
    sa(sp()+3L);
    return 8;
}
private int _8(){
    sa(sp()+sp());

    sa(tm(sp(),40));

    sa(sr());
    gw(4,0,sp());
    return 9;
}
private int _9(){
    if(rd()){if(rd()){return 90;}else{return 89;}}else{if(rd()){return 88;}else{return 10;}}
}
private int _10(){
    sa(8);
    return 11;
}
private int _11(){
    if(rd()){if(rd()){return 87;}else{return 86;}}else{if(rd()){return 85;}else{return 12;}}
}
private int _12(){
    sa(sp()+2L);
    return 13;
}
private int _13(){
    sa(sp()*4L);
    return 14;
}
private int _14(){
    if(rd()){if(rd()){return 84;}else{return 83;}}else{if(rd()){return 82;}else{return 15;}}
}
private int _15(){
    sa(sp()+2L);
    return 16;
}
private int _16(){
    if(sp()!=0)return 28;else return 17;
}
private int _17(){
    gw(4,0,10);
    sp();
    return 18;
}
private int _18(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 3;else return 19;
}
private int _19(){
    gw(41,2,39);
    sp();
    sa(38);
    return 20;
}
private int _20(){
    sa(sr());
    sa(sr()+2);
    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());

    if(sp()!=0)return 27;else return 21;
}
private int _21(){
    sp();
    sa(0);
    return 22;
}
private int _22(){
    sa(sr());

    if(sp()!=0)return 25;else return 23;
}
private int _23(){
    sa(sp()+1L);


    if(sr()<40)return 22;else return 24;
}
private int _24()throws java.io.IOException{
    System.out.print(String.valueOf(gr(2,2)));
    System.out.print(String.valueOf(gr(3,2)));
    System.out.print(String.valueOf(gr(4,2)));
    sp();
    return 98;
}
private int _25(){
    sa(sr());
    sa(sr()+1);
    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()+2L);

    sa(1);
    {long v0=sp();t0=gr(sp(),v0);}
    sa(sp()+2L);

    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()+2L);

    sa(1);
    {long v0=sp();t1=gr(sp(),v0);}
    t2=t0<t1?1:0;

    if((t2)!=0)return 26;else return 23;
}
private int _26(){
    sa(sr()+2);
    sa(2);
    {long v0=sp();t0=gr(sp(),v0);}
    gw(5,0,t0);
    sa(sr());
    sa(sr()+1);
    sa(2);
    {long v0=sp();sa(gr(sp(),v0));}
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+2L);

    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);

    sa(sr()+2);
    sa(gr(5,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()-1L);
    return 22;
}
private int _27(){
    sa(sp()-1L);
    return 20;
}
private int _28(){
    if(sr()!=30)return 29;else return 17;
}
private int _29(){
    if(sr()!=2)return 44;else return 30;
}
private int _30(){
    sp();
    return 31;
}
private int _31(){
    if(rd()){if(rd()){return 43;}else{return 42;}}else{if(rd()){return 41;}else{return 32;}}
}
private int _32(){
    sa(8);
    return 33;
}
private int _33(){
    if(rd()){if(rd()){return 40;}else{return 39;}}else{if(rd()){return 38;}else{return 34;}}
}
private int _34(){
    sa(sp()+2L);
    return 35;
}
private int _35(){
    sa(sr());

    if(sp()!=0)return 36;else return 17;
}
private int _36(){
    sa(sp()-1L);


    if(sp()!=0)return 18;else return 37;
}
private int _37(){
    gw(4,0,0);
    return 18;
}
private int _38(){
    sa(sp()+1L);
    return 35;
}
private int _39(){
    sa(sp()+0L);
    return 35;
}
private int _40(){
    sa(sp()+3L);
    return 35;
}
private int _41(){
    sa(4);
    return 33;
}
private int _42(){
    sa(0);
    return 33;
}
private int _43(){
    sa(12);
    return 33;
}
private int _44(){
    if(sr()!=17)return 45;else return 30;
}
private int _45(){
    if(sr()!=33)return 46;else return 30;
}
private int _46(){
    if(sr()!=7)return 80;else return 47;
}
private int _47(){
    sp();
    return 48;
}
private int _48(){
    if(rd()){if(rd()){return 79;}else{return 78;}}else{if(rd()){return 77;}else{return 49;}}
}
private int _49(){
    sa(8);
    return 50;
}
private int _50(){
    if(rd()){if(rd()){return 76;}else{return 75;}}else{if(rd()){return 74;}else{return 51;}}
}
private int _51(){
    sa(sp()+2L);
    return 52;
}
private int _52(){
    sa(sr());

    if(sp()!=0)return 53;else return 73;
}
private int _53(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 54;else return 72;
}
private int _54(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 55;else return 71;
}
private int _55(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 56;else return 70;
}
private int _56(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 57;else return 69;
}
private int _57(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 58;else return 68;
}
private int _58(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 59;else return 67;
}
private int _59(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 60;else return 67;
}
private int _60(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 61;else return 64;
}
private int _61(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 62;else return 63;
}
private int _62(){
    sp();
    return 18;
}
private int _63(){
    gw(4,0,gr(4,0)-3);
    return 62;
}
private int _64(){
    if(gr(4,0)!=22)return 65;else return 66;
}
private int _65(){
    gw(4,0,12);
    return 62;
}
private int _66(){
    gw(4,0,28);
    return 62;
}
private int _67(){
    gw(4,0,(10*(td((tm(gr(4,0),6))+1,2)))+5);
    return 62;
}
private int _68(){
    gw(4,0,0);
    return 62;
}
private int _69(){
    gw(4,0,5);
    return 62;
}
private int _70(){
    gw(4,0,39);
    return 62;
}
private int _71(){
    gw(4,0,24);
    return 62;
}
private int _72(){
    gw(4,0,11);
    return 62;
}
private int _73(){
    gw(4,0,10);
    return 62;
}
private int _74(){
    sa(sp()+1L);
    return 52;
}
private int _75(){
    sa(sp()+3L);
    return 52;
}
private int _76(){
    sa(sp()+0L);
    return 52;
}
private int _77(){
    sa(4);
    return 50;
}
private int _78(){
    sa(12);
    return 50;
}
private int _79(){
    sa(0);
    return 50;
}
private int _80(){
    if(sr()!=22)return 81;else return 47;
}
private int _81(){
    if(sr()!=36)return 62;else return 47;
}
private int _82(){
    sa(sp()+1L);
    return 16;
}
private int _83(){
    sa(sp()+3L);
    return 16;
}
private int _84(){
    sa(sp()+0L);
    return 16;
}
private int _85(){
    sa(sp()+1L);
    return 13;
}
private int _86(){
    sa(sp()+3L);
    return 13;
}
private int _87(){
    sa(sp()+0L);
    return 13;
}
private int _88(){
    sa(4);
    return 11;
}
private int _89(){
    sa(12);
    return 11;
}
private int _90(){
    sa(0);
    return 11;
}
private int _91(){
    sa(sp()+2L);
    return 8;
}
private int _92(){
    sa(sp()+1L);
    return 8;
}
private int _93(){
    sa(sp()+4L);
    return 8;
}
private int _94(){
    sa(1);
    return 6;
}
private int _95(){
    sa(4);
    return 6;
}
private int _96(){
    sa(3);
    return 6;
}
private int _97(){
    sa(sp()-1L);
    return 1;
}

public void main()throws java.io.IOException{
    int c=0;
    while(c<98){
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
}
}
}
public static void main(String[]a){try{new Program().main();}catch(java.io.IOException e){}}
}
