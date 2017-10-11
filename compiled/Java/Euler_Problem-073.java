/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABADt3N1Lk3EYxvHf6IEk6jGJRtLLBlYkJLPC5cjcZhi9sbIZi9FwEQ6D5kFWY5os1pspEkEr6syoDgIbUimijIWkEiwRlCcnix10VNtBg2m6YjX/hzGQ"+
                                 "7+foPrq5ji9ubk1PkciRROJLn2xybjFN25b0c5L58bUGl2+f60CNsdvmbLOMJHf82tPdojSfGlNHal9VpUYy5ZGGgErctCn1M0+HjP93xCf2CwAAAAAAsOpUz91eo8oN"+
                                 "2qxy9Mw5AAAAAACw2l0slqVcF3DrT9NWc6HDAAAAAACAvLt7uHrjyoVAyueWCh0GAAAAAADk3eaFuGmlC5jMfihpLHQaAAAAAACQd9Ggb1bya+Vw8IVn3cdd0wZDdtvV"+
                                 "72Z/1N0RCIQ69AM95XXPT8Yzzq8xjfXKwfUFemwAAAAA5FlaEr8Xl3/ceKsuGXtTcb00c0iEdRfutahnrdbOkLy495On/75mpwgXLR9zvHQNP+ibf2LXlaVju1PzXnuT"+
                                 "xbHJG+odtXjbk55HZSmvz3i2s6b/RKM9kRaVr3+2PYvELn1T3h3/25ytlQdOGxYMg0cSn93KhssO/3D9djE+MxWd1AWLlyYSoalka5c+0Dta9V4Vf9i+1pI5X6q906r6"+
                                 "B8tNsPstXAAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[24020000];for(int i=0;i<24020000;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<2000&&y<12010)?g[(int)(y*2000+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<2000&&y<12010)g[(int)(y*2000+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(1,1,12000);
    gw(5,1,0);
    gw(2,1,2000);
    gw(6,1,1);
    gw(7,1,1);
    sa(1);
    sa(1);
    sa(1>=gr(6,1)?1:0);
    return 1;
}
private int _1(){
    if(sp()!=0)return 7;else return 2;
}
private int _2(){
    sa(tm(sr(),gr(2,1)));
    sa(gr(7,1)+3);
    {long v0=sp();t0=gr(sp(),v0);}
    t0=(t0!=0)?0:1;

    if((t0)!=0)return 6;else return 3;
}
private int _3(){
    gw(5,1,gr(5,1)+1);
    sa(sr());
    gw(8,1,sp());
    gw(9,1,gr(7,1));
    return 4;
}
private int _4(){
    if(((gr(8,1)>gr(1,1)?1:0)+(gr(9,1)>gr(1,1)?1L:0L))!=0)return 6;else return 5;
}
private int _5(){
    gw(tm(gr(8,1),gr(2,1)),gr(9,1)+3,0);
    t0=sr()+gr(8,1);
    gw(8,1,t0);
    gw(9,1,gr(7,1)+gr(9,1));
    return 4;
}
private int _6(){
    sa(sp()+1L);

    sa(sr()>=gr(6,1)?1:0);
    return 1;
}
private int _7(){
    sp();

    if(sr()!=gr(1,1))return 9;else return 8;
}
private int _8(){
    System.out.print(String.valueOf(gr(5,1))+" ");
    sp();
    return 10;
}
private int _9(){
    sa(sp()+1L);

    t0=td(sr()+1,2);
    gw(6,1,t0);
    sa(sr());
    gw(7,1,sp());
    sa((td(sr(),3))+1);
    sa(sr()>=gr(6,1)?1:0);
    return 1;
}

public void main(){
    int c=0;
    while(c<10){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
