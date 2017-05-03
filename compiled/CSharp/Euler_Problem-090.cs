/* transpiled with BefunCompile v1.1.0 (c) 2015 */
public static class Program
{
private static readonly string _g = "AR+LCAAAAAAABADtVc1uIyEMfhVPmEqrQbM1zE8yCKFK+wDdYw4R0xtXTpz68GuYIZm/tg+wsdoEbGNsfx9OgOt4vb6/A8sCGwl9qbc6MMAcMATGgV2AKfoLTJsAEq6P"+
                                    "UIz2vL0JLyV3UhaOdkrDaFk9qBfedZXyIjkIchDkQDv1mgxqDCAcDOt4e++Y2xgWAfc3zgE1yB4agD+LMvy2MGb7EthUMKU/ec09Ycs+iFp9lh9QGZToL0bhbeDoFQtj"+
                                    "iVJ4lNIPUdty4dOXnIxdx21wyAdP/7cirpRSqQxjJfApI1uL+R5tEe/LuzZrIj5lORYUWdTAUs6sIFgs++id1NA0O+zuYg+1U5GmnBzCeFn5muNDO3n77ZCuN0rUt1j2"+
                                    "3WDS5+U4TG4YbA6G7PA5YT5ExIkC0O+puZIw8UvpzcEu67OjNPPi2/pshsLOBw0Tj5whp20X9X4br9y+NvIuy4zBUli5U+3E0MXEgqWoYq/L6ref4hUZrdUlX9wtpevr"+
                                    "SL8xbCz3vVUHB+1u4MTyF/AzuQ64e7KQeSO/400aPYOm0LCOJ4/KCdMYibyRD95I4s2sXwZJb5f4RYOAtPyoyC95E3Omd7vgjZ1PSM9d9B4O4h3whi14E1mkF77m5Xb6"+
                                    "e3ptGksXt1sEjzjyBW9m4liKpm4Om3gJQuB967GlmcyHNk7lvk0tWSa5mp0ssJ1l6ieL+Brpinbg0vGOOmpadB06Thdj29NDE2SjAUtrmdaSfESyYLKIZAHahKCttpLy"+
                                    "EQQYEnZDidDSrwOpkCCl8dtpH9NGL2Y3SkCyqBJJNbu1mg5pdof9gUBepZIXrAgL4wovlt0NAUVgCP7o9mPFNoOD2jQbJwxM0zjuVIOujnQv7Rz1fqzePSyduPTjAKcn"+
                                    "0p2rGorPnGuSmTYGe/R4Rj+EJaRD0pFNz62wr0SS20tkSpyyAY6mGukr6bDPv+RlOHDZHDO3QL+DujrBr5Pe1Wg4pRcfU+zgaI2iJ+bO6GTFz5MhvjJS9OgUfX3Q1rSX"+
                                    "SlUVb9Bb9pSnPOUp/6n8A5fdc+wQDgAA";
private static readonly long[]  g = System.Array.ConvertAll(zd(System.Convert.FromBase64String(_g)),b=>(long)b);
private static byte[]zd(byte[]o){byte[]d=System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Skip(o, 1));for(int i=0;i<o[0];i++)d=zs(d);return d;}
private static byte[]zs(byte[]o){using(var c=new System.IO.MemoryStream(o))
                                 using(var z=new System.IO.Compression.GZipStream(c,System.IO.Compression.CompressionMode.Decompress))
                                 using(var r=new System.IO.MemoryStream()){z.CopyTo(r);return r.ToArray();}}
private static long gr(long x,long y){return(x>=0&&y>=0&&x<80&&y<45)?g[y*80+x]:0;}
private static void gw(long x,long y,long v){if(x>=0&&y>=0&&x<80&&y<45)g[y*80+x]=v;}
private static System.Collections.Generic.Stack<long> s=new System.Collections.Generic.Stack<long>();
private static long sp(){ return (s.Count==0)?0:s.Pop(); }
private static void sa(long v){ s.Push(v); }
private static long sr(){ return (s.Count==0)?0:s.Peek(); }
private static long td(long a,long b){ return (b==0)?0:(a/b); }
private static long tm(long a,long b){ return (b==0)?0:(a%b); }
static void Main(string[]args)
{
        long t0;
        gw(3,3,29);
        gw(2,0,0);
        gw(17,0,0);
        sa(8);
    _1:
        sa(sp()-1L);

        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        if(sp()!=0)goto _1;else goto _3;
    _3:
        gw(2,1,0);
        gw(2,2,0);
        gw(13,1,0);
        gw(13,2,0);
        sp();
        sa(8);
    _4:
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

        if(sp()!=0)goto _92;else goto _5;
    _5:
        sp();
        sa(9);
    _6:
        sa(sr());
        sa(sr()+8);
        sa(0);
        {long v0=sp();t0=gr(sp(),v0);}

        if((t0)!=0)goto _89;else goto _7;
    _7:
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(td(sp(),10));

        sa(sr()+4);
        sa(2);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;
        t0+=gr(2,2);
        gw(2,2,t0);
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sp()*sp());

        sa(tm(sp(),10));


        if(sr()!=9)goto _88;else goto _8;
    _8:
        gw(2,1,(((gr(10,1))!=0)?0:1)+gr(2,1));
        gw(10,1,1);
        sp();
    _9:
        sa(sp()-1L);

        sa(sr());

        if(sp()!=0)goto _6;else goto _10;
    _10:
        sp();

        if((gr(2,1)>6?1:0)+(gr(2,2)>6?1L:0L)==0)goto _17;else goto _11;
    _11:
        gw(17,0,((gr(17,0))!=0)?0:1);
        sa(8);
        sa(8);
        sa(gr(17,0));
    _12:
        if(sp()!=0)goto _16;else goto _13;
    _13:
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _14;else goto _15;
    _14:
        System.Console.Out.Write(gr(2,0));
        sp();
        return;
    _15:
        sa(sp()-1L);

        sa(sr());
        sa(sr());
        sa(sr());
        sa(sr()+9);
        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        sa((sp()!=0)?0:1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+9L);

        sa(0);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sp()+9L);

        sa(0);
        {long v0=sp();sa(gr(sp(),v0));}
        goto _12;
    _16:
        sp();
        sp();
        sa(0);
        goto _3;
    _17:
        if(6!=gr(2,1))goto _87;else goto _18;
    _18:
        sa(2);
    _19:
        if(gr(2,2)!=6)goto _20;else goto _86;
    _20:
        sa(9);
        sa(gr(13,2));
    _21:
        if(sp()!=0)goto _22;else goto _45;
    _22:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _23;else goto _24;
    _23:
        sa(sr()+4);
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        goto _21;
    _24:
        sp();
        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _44;else goto _26;
    _26:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _31;else goto _27;
    _27:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _28;else goto _30;
    _28:
        gw(17,0,((gr(17,0))!=0)?0:1);
        sp();
        sa(8);
        sa(8);
        sa(gr(17,0));
        goto _12;
    _30:
        return;
    _31:
        sp();
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _33:
        if(sp()!=0)goto _34;else goto _28;
    _34:
        sa(sr()+4);
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
    _35:
        if(sp()!=0)goto _43;else goto _36;
    _36:
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}

        if(5!=gr(2,1))goto _38;else goto _37;
    _37:
        sa(1);
        goto _19;
    _38:
        sa(9);
        sa(gr(13,1));
    _39:
        if(sp()!=0)goto _40;else goto _42;
    _40:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _41;else goto _31;
    _41:
        sa(sr()+4);
        sa(1);
        {long v0=sp();sa(gr(sp(),v0));}
        goto _39;
    _42:
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(0);
        goto _19;
    _43:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        goto _33;
    _44:
        sp();
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _40;
    _45:
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}

        if(5!=gr(2,2))goto _46;else goto _85;
    _46:
        sa(9);
        sa(gr(13,2));
    _47:
        if(sp()!=0)goto _48;else goto _52;
    _48:
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _51;else goto _49;
    _49:
        sp();
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}

        if(sp()!=0)goto _23;else goto _24;
    _51:
        sa(sr()+4);
        sa(2);
        {long v0=sp();sa(gr(sp(),v0));}
        goto _47;
    _52:
        sa(sr());
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(4,0,(((gr(10,1))!=0)?0:1)+gr(13,1));
        gw(5,0,(((gr(10,2))!=0)?0:1)+gr(13,2));
        gw(6,0,0);
        gw(7,0,0);
        gw(6,0,gr(13,1)+(gr(6,0)*2));
        sa(0);
    _53:
        sa(0);
    _54:
        sa(8);
    _55:
        sa(sr()+4);
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        t0+=gr(6,0)*2;
        gw(6,0,t0);
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _55;else goto _57;
    _57:
        gw(7,0,gr(13,2)+(gr(7,0)*2));
        sp();
        sa(8);
    _58:
        sa(sr()+4);
        sa(2);
        {long v0=sp();t0=gr(sp(),v0);}
        t0+=gr(7,0)*2;
        gw(7,0,t0);
        sa(sr()-1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        if(sp()!=0)goto _58;else goto _60;
    _60:
        sp();
        sa(gr(7,0));
        sa(gr(6,0));

        if(gr(6,0)>gr(7,0))goto _61;else goto _62;
    _61:
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
    _62:
        sa(sp()*1024L);

        sa(sp()+sp());

        t0=sp();
        gw(3,0,t0);
        sa(1279);
        sa(gr(79,15+gr(3,3)));
        sa(gr(79,15+gr(3,3))-gr(3,0));
    _63:
        if(sp()!=0)goto _64;else goto _84;
    _64:
        sa(sp()-35L);

        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _65;else goto _83;
    _65:
        sa(gr(3,0));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(tm(sr(),80));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),80));

        sa(sp()+gr(3,3));

        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        gw(2,0,gr(2,0)+1);
    _66:
        sa(sp()+1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _82;else goto _67;
    _67:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _80;else goto _68;
    _68:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _79;else goto _69;
    _69:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _70;else goto _30;
    _70:
        gw(10,1,1);
        gw(13,1,0);
        gw(10,2,1);
        gw(13,2,0);
        sp();
    _71:
        if((gr(4,0))==0)goto _72;else goto _73;
    _72:
        gw(10,1,0);
        gw(13,1,1);
        gw(6,0,0);
        gw(7,0,0);
        gw(6,0,gr(13,1)+(gr(6,0)*2));
        sa(1);
        goto _54;
    _73:
        if((gr(5,0))==0)goto _78;else goto _74;
    _74:
        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _77;else goto _75;
    _75:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _49;else goto _76;
    _76:
        sa(sp()-1L);

        sa(sr());
        sa((sp()!=0)?0:1);

        if(sp()!=0)goto _24;else goto _30;
    _77:
        sp();
        sa(sr());
        sa(0);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _48;
    _78:
        gw(10,2,0);
        gw(13,2,1);
        gw(6,0,0);
        gw(7,0,0);
        gw(6,0,gr(13,1)+(gr(6,0)*2));
        sa(-1);
        goto _54;
    _79:
        gw(10,1,1);
        gw(13,1,0);
        sp();
        goto _73;
    _80:
        sp();

        if((gr(4,0)+gr(5,0))!=0)goto _71;else goto _81;
    _81:
        gw(10,1,0);
        gw(13,1,1);
        gw(10,2,0);
        gw(13,2,1);
        gw(6,0,0);
        gw(7,0,0);
        gw(6,0,gr(13,1)+(gr(6,0)*2));
        sa(2);
        goto _54;
    _82:
        gw(10,2,1);
        gw(13,2,0);
        sp();
        goto _74;
    _83:
        sa(sp()-1L);

        sa(sr());
        sa(tm(sr(),80));
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(td(sp(),80));

        sa(sp()+gr(3,3));

        {long v0=sp();sa(gr(sp(),v0));}
        sa(sr()-gr(3,0));
        goto _63;
    _84:
        sp();
        sp();
        goto _66;
    _85:
        gw(4,0,(((gr(10,1))!=0)?0:1)+gr(13,1));
        gw(5,0,(((gr(10,2))!=0)?0:1)+gr(13,2));
        gw(6,0,0);
        gw(7,0,0);
        gw(6,0,gr(13,1)+(gr(6,0)*2));
        sa(1);
        goto _53;
    _86:
        gw(4,0,(((gr(10,1))!=0)?0:1)+gr(13,1));
        gw(5,0,(((gr(10,2))!=0)?0:1)+gr(13,2));
        gw(6,0,0);
        gw(7,0,0);
        gw(6,0,gr(13,1)+(gr(6,0)*2));
        sa(2);
        goto _53;
    _87:
        sa(9);
        sa(gr(13,1));
        goto _35;
    _88:
        sa(sr()+4);
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;
        t0+=gr(2,1);
        gw(2,1,t0);
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _9;
    _89:
        sa(sr());
        sa(sr());
        sa(sp()*sp());

        sa(td(sp(),10));

        sa(sr()+4);
        sa(1);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;
        t0+=gr(2,1);
        gw(2,1,t0);
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(1);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        sa(sr());
        sa(sp()*sp());

        sa(tm(sp(),10));


        if(sr()!=9)goto _91;else goto _90;
    _90:
        gw(2,2,(((gr(10,2))!=0)?0:1)+gr(2,2));
        gw(10,2,1);
        sp();
        goto _9;
    _91:
        sa(sr()+4);
        sa(2);
        {long v0=sp();t0=gr(sp(),v0);}
        t0=(t0!=0)?0:1;
        t0+=gr(2,2);
        gw(2,2,t0);
        sa(1);
        {long v0=sp();long v1=sp();sa(v0);sa(v1);}
        sa(sp()+4L);

        sa(2);
        {long v0=sp();long v1=sp();gw(v1,v0,sp());}
        goto _9;
    _92:
        sa(sp()-1L);
        goto _4;
}
}
