/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtVc1uIyEMfhVPmEqrQbM1zE8yCKFK+wDdYw4R0xtXTpz68GuYIZm/tg+wsdoEbGNsfx9OgOt4vb6/A8sCGwl9qbc6MMAcMATGgV2AKfoLTJsAEq6P"+
                                 "UIz2vL0JLyV3UhaOdkrDaFk9qBfedZXyIjkIchDkQDv1mgxqDCAcDOt4e++Y2xgWAfc3zgE1yB4agD+LMvy2MGb7EthUMKU/ec09Ycs+iFp9lh9QGZToL0bhbeDoFQtj"+
                                 "iVJ4lNIPUdty4dOXnIxdx21wyAdP/7cirpRSqQxjJfApI1uL+R5tEe/LuzZrIj5lORYUWdTAUs6sIFgs++id1NA0O+zuYg+1U5GmnBzCeFn5muNDO3n77ZCuN0rUt1j2"+
                                 "3WDS5+U4TG4YbA6G7PA5YT5ExIkC0O+puZIw8UvpzcEu67OjNPPi2/pshsLOBw0Tj5whp20X9X4br9y+NvIuy4zBUli5U+3E0MXEgqWoYq/L6ref4hUZrdUlX9wtpevr"+
                                 "SL8xbCz3vVUHB+1u4MTyF/AzuQ64e7KQeSO/400aPYOm0LCOJ4/KCdMYibyRD95I4s2sXwZJb5f4RYOAtPyoyC95E3Omd7vgjZ1PSM9d9B4O4h3whi14E1mkF77m5Xb6"+
                                 "e3ptGksXt1sEjzjyBW9m4liKpm4Om3gJQuB967GlmcyHNk7lvk0tWSa5mp0ssJ1l6ieL+Brpinbg0vGOOmpadB06Thdj29NDE2SjAUtrmdaSfESyYLKIZAHahKCttpLy"+
                                 "EQQYEnZDidDSrwOpkCCl8dtpH9NGL2Y3SkCyqBJJNbu1mg5pdof9gUBepZIXrAgL4wovlt0NAUVgCP7o9mPFNoOD2jQbJwxM0zjuVIOujnQv7Rz1fqzePSyduPTjAKcn"+
                                 "0p2rGorPnGuSmTYGe/R4Rj+EJaRD0pFNz62wr0SS20tkSpyyAY6mGukr6bDPv+RlOHDZHDO3QL+DujrBr5Pe1Wg4pRcfU+zgaI2iJ+bO6GTFz5MhvjJS9OgUfX3Q1rSX"+
                                 "SlUVb9Bb9pSnPOUp/6n8A5fdc+wQDgAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[3600];for(int i=0;i<3600;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<45)?g[(int)(y*80+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<45)g[(int)(y*80+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(3,3,29);
    gw(2,0,0);
    gw(17,0,0);
    sa(8);
    sa(8);
    return 1;
}
private int _1(){
    if(sp()!=0)return 94;else return 2;
}
private int _2(){
    gw(2,1,0);
    gw(2,2,0);
    gw(13,1,0);
    gw(13,2,0);
    sp();
    sa(9);
    sa(9);
    return 3;
}
private int _3(){
    if(sp()!=0)return 93;else return 4;
}
private int _4(){
    sp();
    sa(9);
    sa(9);
    return 5;
}
private int _5(){
    if(sp()!=0)return 85;else return 6;
}
private int _6(){
    sp();

    if(((gr(2,1)>6?1:0)+(gr(2,2)>6?1L:0L))!=0)return 7;else return 13;
}
private int _7(){
    gw(17,0,((gr(17,0))!=0)?0:1);
    sa(8);
    sa(8);
    sa(gr(17,0));
    return 8;
}
private int _8(){
    if(sp()!=0)return 9;else return 10;
}
private int _9(){
    sp();
    sp();
    sa(0);
    return 2;
}
private int _10(){
    if(sp()!=0)return 12;else return 11;
}
private int _11(){
    System.out.print(String.valueOf(gr(2,0))+" ");
    sp();
    return 95;
}
private int _12(){
    sa(sp()-1L);

    sa(sr());
    sa(sr());
    sa(sr());
    sa(((gr(sr()+9,0))!=0)?0:1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+9L);

    sa(0);
    {long v0=sp();sa(gr(sp(),v0));}
    return 8;
}
private int _13(){
    if(gr(2,1)!=6)return 84;else return 14;
}
private int _14(){
    sa(2);
    return 15;
}
private int _15(){
    if(gr(2,2)!=6)return 83;else return 16;
}
private int _16(){
    sa(2);
    return 17;
}
private int _17(){
    gw(4,0,(((gr(10,1))!=0)?0:1)+gr(13,1));
    gw(5,0,(((gr(10,2))!=0)?0:1)+gr(13,2));
    sa(0);
    return 18;
}
private int _18(){
    gw(6,0,0);
    gw(7,0,0);
    gw(6,0,gr(13,1)+(gr(6,0)*2));
    sa(8);
    sa(9);
    return 19;
}
private int _19(){
    if(sp()!=0)return 82;else return 20;
}
private int _20(){
    gw(7,0,gr(13,2)+(gr(7,0)*2));
    sp();
    sa(8);
    sa(9);
    return 21;
}
private int _21(){
    if(sp()!=0)return 81;else return 22;
}
private int _22(){
    sp();
    sa(gr(7,0));
    sa(gr(6,0));

    if(gr(6,0)>gr(7,0))return 23;else return 24;
}
private int _23(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 24;
}
private int _24(){
    sa(sp()*1024L);

    sa(sp()+sp());

    t0=sp();
    gw(3,0,t0);
    sa(1279);
    sa(gr(79,15+gr(3,3)));
    sa(gr(79,15+gr(3,3))-gr(3,0));
    return 25;
}
private int _25(){
    if(sp()!=0)return 26;else return 80;
}
private int _26(){
    sa(sp()-35L);


    if(sp()!=0)return 79;else return 27;
}
private int _27(){
    sa(gr(3,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr()%80);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/80L);

    sa(sp()+gr(3,3));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    gw(2,0,gr(2,0)+1);
    return 28;
}
private int _28(){
    sa(sp()+1L);

    sa(sr());

    if(sp()!=0)return 29;else return 78;
}
private int _29(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 30;else return 76;
}
private int _30(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 31;else return 75;
}
private int _31(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 32;else return 33;
}
private int _32(){
    return 95;
}
private int _33(){
    gw(10,1,1);
    gw(13,1,0);
    gw(10,2,1);
    gw(13,2,0);
    sp();
    return 34;
}
private int _34(){
    if((gr(4,0))!=0)return 36;else return 35;
}
private int _35(){
    gw(10,1,0);
    gw(13,1,1);
    sa(1);
    return 18;
}
private int _36(){
    if((gr(5,0))!=0)return 37;else return 74;
}
private int _37(){
    sa(sr());

    if(sp()!=0)return 38;else return 73;
}
private int _38(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 39;else return 60;
}
private int _39(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 32;else return 40;
}
private int _40(){
    sp();
    return 41;
}
private int _41(){
    t0=1;
    sa(sr());

    if(sp()!=0)return 42;else return 59;
}
private int _42(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 43;else return 45;
}
private int _43(){
    sa(sp()-1L);

    sa(sr());

    if(sp()!=0)return 32;else return 44;
}
private int _44(){
    sp();
    gw(17,0,((gr(17,0))!=0)?0:1);
    sa(8);
    sa(8);
    sa(gr(17,0));
    return 8;
}
private int _45(){
    sp();
    return 46;
}
private int _46(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 47;
}
private int _47(){
    if(sp()!=0)return 48;else return 44;
}
private int _48(){
    sa(gr(sr()+4,1));
    return 49;
}
private int _49(){
    if(sp()!=0)return 58;else return 50;
}
private int _50(){
    sa(sr());
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}

    if(gr(2,1)!=5)return 52;else return 51;
}
private int _51(){
    sa(1);
    return 15;
}
private int _52(){
    sa(9);
    sa(gr(13,1));
    return 53;
}
private int _53(){
    if(sp()!=0)return 54;else return 57;
}
private int _54(){
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)return 55;else return 56;
}
private int _55(){
    sa(gr(sr()+4,1));
    return 53;
}
private int _56(){
    t0=2;
    sp();
    return 46;
}
private int _57(){
    sa(sr());
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(0);
    return 15;
}
private int _58(){
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 47;
}
private int _59(){
    sp();
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 54;
}
private int _60(){
    sp();
    return 61;
}
private int _61(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)return 62;else return 40;
}
private int _62(){
    sa(gr(sr()+4,2));
    return 63;
}
private int _63(){
    if(sp()!=0)return 72;else return 64;
}
private int _64(){
    sa(sr());
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}

    if(gr(2,2)!=5)return 66;else return 65;
}
private int _65(){
    sa(1);
    return 17;
}
private int _66(){
    sa(9);
    sa(gr(13,2));
    return 67;
}
private int _67(){
    if(sp()!=0)return 68;else return 71;
}
private int _68(){
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)return 69;else return 70;
}
private int _69(){
    sa(gr(sr()+4,2));
    return 67;
}
private int _70(){
    t0=2;
    sp();
    return 61;
}
private int _71(){
    sa(sr());
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(0);
    return 17;
}
private int _72(){
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}

    if(sp()!=0)return 62;else return 40;
}
private int _73(){
    sp();
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 68;
}
private int _74(){
    gw(10,2,0);
    t0=0;
    gw(13,2,1);
    sa(-1);
    return 18;
}
private int _75(){
    gw(10,1,1);
    gw(13,1,0);
    sp();
    return 36;
}
private int _76(){
    sp();

    if((gr(4,0)+gr(5,0))!=0)return 34;else return 77;
}
private int _77(){
    gw(10,1,0);
    gw(13,1,1);
    gw(10,2,0);
    gw(13,2,1);
    sa(2);
    return 18;
}
private int _78(){
    gw(10,2,1);
    gw(13,2,0);
    sp();
    return 37;
}
private int _79(){
    sa(sp()-1L);

    sa(sr());
    sa(sr()%80);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/80L);

    sa(sp()+gr(3,3));

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sr()-gr(3,0));
    return 25;
}
private int _80(){
    sp();
    sp();
    return 28;
}
private int _81(){
    gw(7,0,gr(sr()+4,2)+(gr(7,0)*2));
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 21;
}
private int _82(){
    gw(6,0,gr(sr()+4,1)+(gr(6,0)*2));
    sa(sr()-1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    return 19;
}
private int _83(){
    sa(9);
    sa(gr(13,2));
    return 63;
}
private int _84(){
    sa(9);
    sa(gr(13,1));
    return 49;
}
private int _85(){
    sa(sr());

    if((gr(sr()+8,0))!=0)return 90;else return 86;
}
private int _86(){
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()/10L);

    gw(2,2,(((gr(sr()+4,2))!=0)?0:1)+gr(2,2));
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sp()*sp());

    sa(sp()%10L);


    if(sr()!=9)return 89;else return 87;
}
private int _87(){
    gw(2,1,(((gr(10,1))!=0)?0:1)+gr(2,1));
    gw(10,1,1);
    sp();
    return 88;
}
private int _88(){
    t0=6;
    sa(sp()-1L);

    sa(sr());
    return 5;
}
private int _89(){
    gw(2,1,(((gr(sr()+4,1))!=0)?0:1)+gr(2,1));
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 88;
}
private int _90(){
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()/10L);

    gw(2,1,(((gr(sr()+4,1))!=0)?0:1)+gr(2,1));
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sp()*sp());

    sa(sp()%10L);


    if(sr()!=9)return 92;else return 91;
}
private int _91(){
    gw(2,2,(((gr(10,2))!=0)?0:1)+gr(2,2));
    gw(10,2,1);
    sp();
    return 88;
}
private int _92(){
    gw(2,2,(((gr(sr()+4,2))!=0)?0:1)+gr(2,2));
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 88;
}
private int _93(){
    sa(sp()-1L);

    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+4L);

    sa(2);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 3;
}
private int _94(){
    sa(sp()-1L);

    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+9L);

    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 1;
}

public void main(){
    int c=0;
    while(c<95){
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
}
}
}
public static void main(String[]a){new Program().main();}
}