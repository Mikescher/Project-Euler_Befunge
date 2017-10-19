/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABACNksFqwzAMhl9FzZpLTYYktxmIYPYYOwSTm646+eSHn9zQkZaQTmAhWd8fS3bKz93gnZV/cue3xGrpC4DYAJPgTCbSURfKgaAOyiSBDGeYdvrzZRzp"+
                                 "vFM76CKykh4d2wjuKxTj65QaTcG3yrYupEtdM2w+52io7G6iB5cfPLYjraQrK2pszqNsf5wPEcjFa7qZxjuI+DxdGWVwdrwEuN0mNB79jjbI9+eaJPZ+OuyGMLLWvTFf"+
                                 "n+3DRZIishUP0O9gkMsCp1fxXZdOM/cQam+MgUQZZfcV8sLilaNfJG/ip2/8AoE9XKOoAgAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[680];for(int i=0;i<680;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<40&&y<17)?g[(int)(y*40+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<40&&y<17)g[(int)(y*40+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
private int _0(){
    gw(1,2,7);
    gw(0,1,0);
    gw(0,0,49);
    sp();
    sa(1);
    sa(1-gr(1,2));
    return 1;
}
private int _1(){
    if(sp()!=0)return 2;else return 3;
}
private int _2(){
    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(1);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    sa(sr()+49);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(0);
    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sp()+1L);

    sa(sr()-gr(1,2));
    return 1;
}
private int _3(){
    gw(3,2,1);
    sp();
    return 4;
}
private int _4(){
    if(gr(3,2)>gr(gr(3,2),1))return 7;else return 5;
}
private int _5(){
    gw(gr(3,2),1,0);
    return 6;
}
private int _6(){
    gw(3,2,gr(3,2)+1);
    return 4;
}
private int _7(){
    if((gr(3,2)%2)!=0)return 17;else return 8;
}
private int _8(){
    gw(4,2,0);
    return 9;
}
private int _9(){
    sa(gr(gr(4,2),0));
    gw(gr(4,2),0,gr(gr(3,2),0));
    gw(gr(3,2),0,sp());
    gw(gr(3,2),1,gr(gr(3,2),1)+1);
    gw(3,2,0);
    gw(6,2,gr(1,2));
    sa(0);
    return 10;
}
private int _10(){
    sa(gr(6,2)-1);
    gw(6,2,gr(6,2)-1);
    sa(0);
    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()-48L);

    sa(sp()+sp());


    if((gr(6,2))!=0)return 16;else return 11;
}
private int _11(){
    gw(0,2,3);
    sa(sr());
    sa(sr());
    sa(sr()<=2?1:0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()%2L);

    sa(sp()+sp());


    if(sp()!=0)return 13;else return 12;
}
private int _12(){
    sp();
    sp();
    return 6;
}
private int _13(){
    if(sr()>((gr(0,2)-2)*(gr(0,2)-2)))return 14;else return 15;
}
private int _14(){
    sa(tm(sr(),gr(0,2)));
    gw(0,2,gr(0,2)+1);

    if(sp()!=0)return 13;else return 12;
}
private int _15(){
    sp();
    System.out.print(String.valueOf((long)(sp()))+" ");
    return 18;
}
private int _16(){
    sa(sp()*10L);
    return 10;
}
private int _17(){
    gw(4,2,gr(gr(3,2),1));
    return 9;
}

public void main(){
    int c=0;
    while(c<18){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
