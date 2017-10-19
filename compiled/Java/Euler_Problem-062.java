/* transpiled with BefunCompile v1.3.0 (c) 2017 */
class Program{
private final static String _g = "Ah+LCAAAAAAABACT7+ZgAAEWhrfX7+Y1GUgc+xi9UnPelsRLfDL7FM/qLbl4eF7REUHx/YtuLuuOvuN+6ENlHTsXC+/J+/seLOBaytmfVOHDw++VWhzPfLZBW07kcPOj"+
                                 "FexHPyyQADGTKgJ4+LseOhraaLTRSnCK1JWzfM1xnvs9t/aHlW6v7/s3/4LG/W+XrwVnlz3bOCXz9vXjzrevzSmbfa/j/jetHUGrNPb5va6yv+96+T1v/Lo7B3dttl33"+
                                 "0Tqo9vGdjT5T0//+FpgjKjhZfef7UNHl0v8EvJfverB6H9enDL/mu27xq7d4Gp2rPfpFvWv72oNmvSWKuzYYB7rtrPpVHCjC//JLRfj6z7Mjvv8SncN6WuRa4Je6K7P/"+
                                 "MHe4pq+fY7jXR/nAPv/GP8onjA9vXxlTKKYTpDGlz/G56vqpGdU/3iy0lRCs36P8RZz7vvu6H6o368881+PfMePT3f9/AnxEl//69PfPfYvH+re49af/CM8qYmAAAFun"+
                                 "LAS3AQAA";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[29290];for(int i=0;i<29290;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<505&&y<58)?g[(int)(y*505+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<505&&y<58)g[(int)(y*505+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0;
private int _0(){
    gw(2,8,5);
    gw(2,4,501);
    gw(2,5,48);
    gw(2,6,24048);
    gw((tm(24047,gr(2,4)))+4,td(24047,gr(2,4)),0);
    sa(24047);
    sa(24047);
    return 1;
}
private int _1(){
    if(sp()!=0)return 20;else return 2;
}
private int _2(){
    gw(2,2,1);
    sa(1);
    sa(0);
    sa(1);
    sa(1);
    sa(1);
    return 3;
}
private int _3(){
    if(sp()!=0)return 4;else return 8;
}
private int _4(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(9);
    return 5;
}
private int _5(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 7;else return 6;
}
private int _6(){
    sp();
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()/10L);

    sa(sr()%10);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 3;
}
private int _7(){
    sa(sp()-1L);

    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()*9L);
    return 5;
}
private int _8(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sp();
    sp();
    return 9;
}
private int _9(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());

    if(sp()!=0)return 10;else return 11;
}
private int _10(){
    sa(sp()+sp());
    return 9;
}
private int _11(){
    sa(sp()+sp());

    sa(sr());
    gw(2,0,sp());
    sa(0);
    sa(gr(4,0));
    sa(gr(4,0));
    return 12;
}
private int _12(){
    if(sp()!=0)return 13;else return 19;
}
private int _13(){
    sa(sp()-gr(2,0));


    if(sp()!=0)return 18;else return 14;
}
private int _14(){
    sa(sp()*3L);

    sa(sr()+2);
    sa((tm(sr(),gr(2,4)))+4);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sp()+1L);


    if((sr()-gr(2,8))!=0)return 16;else return 15;
}
private int _15(){
    sp();
    sa(sp()+1L);

    sa((tm(sr(),gr(2,4)))+4);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));

    {long v0=sp();t0=gr(sp(),v0);}
    System.out.print(String.valueOf(t0)+" ");
    sp();
    sp();
    sp();
    return 21;
}
private int _16(){
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+2L);

    sa((tm(sr(),gr(2,4)))+4);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 17;
}
private int _17(){
    sp();
    sa(sp()+1L);

    sa(sr());
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    t0=sp();
    sa(sp()*t0);

    sa(sr());
    gw(2,2,sp());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr()%10);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sr());
    return 3;
}
private int _18(){
    sa(sp()+1L);

    sa(sr()*3);
    sa((tm(sr(),gr(2,4)))+4);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));

    {long v0=sp();sa(gr(sp(),v0));}
    sa(sr());
    return 12;
}
private int _19(){
    sp();
    sa(sp()*3L);

    sa(sr());
    sa(sr());
    sa(gr(2,0));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),gr(2,4)))+4);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(gr(2,2));
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+1L);

    sa((tm(sr(),gr(2,4)))+4);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(1);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(sp()+2L);

    sa((tm(sr(),gr(2,4)))+4);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    return 17;
}
private int _20(){
    sa(sp()-1L);

    sa(sr());
    sa(0);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa((tm(sr(),gr(2,4)))+4);
    {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    sa(td(sp(),gr(2,4)));

    {long v0=sp();long v1=sp();gw(v1,v0,sp());}
    sa(sr());
    return 1;
}

public void main(){
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
public static void main(String[]a){new Program().main();}
}
