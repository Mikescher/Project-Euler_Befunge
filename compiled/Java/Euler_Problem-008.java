/* transpiled with BefunCompile v1.2.0 (c) 2017 */
class Program{
private final static String _g = "AR+LCAAAAAAABADtl81uG0cQhF+FYJyLaCf9O90tJEIeJHBy45UnPb+/kS0ECAwo1vKYAYYr7nC3pquraqDz81nklvHwqFzSHh4eTW4PLrfOS8hNkrmYxWy5nRjPp2Pj"+
                                 "SVOuvPNpyRW0689/8vHrXK5nOX964KZeHlnmR5+C+dPzX48t17+5fnjKl1U25V9XTsPGTk8lV7n2erh85K9+fez8+/kjT/7yxz/Yn//jHn9jfvixR773ineNp/7K+eaH"+
                                 "ei+PdvpG0umVJVbmIrcXrk6brG8Vf37PZr+/0de7n+n9Ra9Sbz/yzvHDe74r+v/j36NcV2mtdHWXZTE6Zqk6qyJsZUWFeabvlRiP45izpj1NXK0qUpbbMp+sdm1RVoNL"+
                                 "r4nqTu3w45idvTSXVI+qUUhMRk6Kltdku+ukdbpJtyQEHMdUyxCqgULNTvNeTsbyZY3byFA4oAbRLgHH9fY73xpr9awVTWURaXvSYYrUzhXiwnYUBrSM/bjqHbhdZjaN"+
                                 "NMy9gWj1dF9Wa2lYW8sKRrOvTULFHMd08eyRslkwiTbpbYRUISQY9lbJTfq41CwB+zhmIRYLK9jr9oHJqRE+dwvHdLZ2p7aCWsar7oCJAa0cawoFQSqOUDPBkcEuZCq3"+
                                 "ytBZ4ha0dA+vpGUHLCKUVXhhiTrsUjImiuAewo1QtmZKMswddJu+plphtDrQK8bBoanwCsXLXiyjsxf5ZtF2HJOCqCDUK6FZqJO0GzFUi2i2tHphIY30VBGC8A6Ypmt5"+
                                 "wSZqJXPwjQiCIQfCdxai2aDDlY1mF90+jqlri7Y0aoa+hQ2mxKbLYyUxj1/Jdt1BwULQ5Dtg1ovdyXleHLkgEoEupLoIBPJJDQ8RD0TygoK4Qz/xJh4040DbqjVUqnts"+
                                 "L0pStxYETygkkwkhfRyTrOG4Eu8kzikUmCD6Bpe+ZG1vzkkNchBpDcFxHLPhVQg8lEQA7NaRu5UBkgg6wp6cAjC8zzvOdrlDP2XrkTyITe7EPsZAxBW2rUkn+X8CISeB"+
                                 "SyxgnjyOWUohtoZKu+mq7MOE+po0EhRsWcnBaULwcZbinuOYXwA+olORJA0AAA==";
private final long[] g=zc(zd(java.util.Base64.getDecoder().decode(_g)));
private long[]zc(byte[]b){long[]r=new long[3364];for(int i=0;i<3364;i++)r[i]=b[i];return r;}
private byte[]zd(byte[]o){byte[]d=java.util.Arrays.copyOfRange(o,1,o.length);for(int i=0;i<o[0];i++)d=zs(d);return d;}
private byte[]zs(byte[]o){try{
java.io.ByteArrayInputStream  y=new java.io.ByteArrayInputStream(o);
java.util.zip.GZIPInputStream s=new java.util.zip.GZIPInputStream(y);
java.io.ByteArrayOutputStream a=new java.io.ByteArrayOutputStream();
int res=0;byte buf[]=new byte[1024];while(res>=0){res=s.read(buf,0,1024);if(res>0)a.write(buf,0,res);}return a.toByteArray();
}catch(java.io.IOException e){return null;}}
private long gr(long x,long y){return(x>=0&&y>=0&&x<116&&y<29)?g[(int)(y*116+x)]:0;}
private void gw(long x,long y,long v){if(x>=0&&y>=0&&x<116&&y<29)g[(int)(y*116+x)]=v;}
private long td(long a,long b){return(b==0)?0:(a/b);}
private long tm(long a,long b){return(b==0)?0:(a%b);}
private final static java.util.Stack<Long> s=new java.util.Stack<Long>();
private long sp(){return(s.size()==0)?0:s.pop();}
private void sa(long v){s.push(v);}
private long sr(){return(s.size()==0)?0:s.peek();}
long t0,t1;
private int _0(){
    gw(0,0,118);
    gw(1,0,20);
    gw(2,0,50);
    gw(3,0,1000);
    gw(4,0,13);
    gw(5,0,0);
    gw(6,0,0);
    gw(7,0,0);
    gw(8,0,0);
    return 1;
}
private int _1(){
    gw(6,0,gr(5,0));
    t0=gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48;
    return 2;
}
private int _2(){
    t1=gr(6,0)+1;
    gw(6,0,gr(6,0)+1);
    t1-=gr(5,0);
    t1-=gr(4,0);

    if((t1)!=0)return 3;else return 4;
}
private int _3(){
    t0*=gr(tm(gr(6,0),gr(2,0)),(td(gr(6,0),gr(2,0)))+9)-48;
    return 2;
}
private int _4(){
    if(t0>gr(8,0))return 10;else return 5;
}
private int _5(){
    t0=gr(5,0)+1;
    gw(5,0,gr(5,0)+1);
    t0-=gr(3,0);

    if((t0)!=0)return 1;else return 6;
}
private int _6(){
    gw(7,0,9);
    return 7;
}
private int _7(){
    System.out.print(String.valueOf((char)(gr(gr(7,0),0)+48)));

    if(gr(7,0)-8!=gr(4,0))return 9;else return 8;
}
private int _8(){
    System.out.print('=');
    System.out.print(String.valueOf(gr(8,0))+" ");
    return 13;
}
private int _9(){
    gw(7,0,gr(7,0)+1);
    return 7;
}
private int _10(){
    gw(8,0,t0);
    gw(6,0,0);
    return 11;
}
private int _11(){
    gw(gr(6,0)+9,0,gr(tm(gr(6,0)+gr(5,0),gr(2,0)),(td(gr(6,0)+gr(5,0),gr(2,0)))+9)-48);
    t0=gr(6,0)+1;
    gw(6,0,gr(6,0)+1);
    t0-=gr(4,0);
    return 12;
}
private int _12(){
    if((t0)!=0)return 11;else return 5;
}

public void main(){
    int c=0;
    while(c<13){
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
}
}
}
public static void main(String[]a){new Program().main();}
}
