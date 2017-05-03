#!/usr/bin/env python3

# transpiled with BefunCompile v1.1.0 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABACNksFqwzAMhl9FzZpLTYYktxmIYPYYOwSTm646+eSHn9zQkZaQTmAhWd8fS3bKz93gnZV/cue3xGrpC4DYAJPgTCbSURfKgaAOyiSBDGeYdvrzZRzp"
  + "vFM76CKykh4d2wjuKxTj65QaTcG3yrYupEtdM2w+52io7G6iB5cfPLYjraQrK2pszqNsf5wPEcjFa7qZxjuI+DxdGWVwdrwEuN0mNB79jjbI9+eaJPZ+OuyGMLLWvTFf"
  + "n+3DRZIishUP0O9gkMsCp1fxXZdOM/cQam+MgUQZZfcV8sLilaNfJG/ip2/8AoE9XKOoAgAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<40 and y<17):
        return g[y*40 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<40 and y<17):
        g[y*40 + x]=v;
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    gw(1,2,7)
    gw(0,1,0)
    gw(0,0,49)
    sp();
    sa(1)
    sa(1-gr(1,2))
    return 1
def _1():
    return (2)if(sp()!=0)else(3)
def _2():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(sr()+49)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+1);

    sa(sr()-gr(1,2))
    return 1
def _3():
    gw(3,2,1)
    sp();
    return 4
def _4():
    return (6)if(gr(3,2)>gr(gr(3,2),1))else(5)
def _5():
    gw(gr(3,2),1,0)
    gw(3,2,gr(3,2)+1)
    return 4
def _6():
    return (17)if(tm(gr(3,2),2)!=0)else(7)
def _7():
    gw(4,2,0)
    return 8
def _8():
    sa(gr(gr(4,2),0))
    gw(gr(4,2),0,gr(gr(3,2),0))
    gw(gr(3,2),0,sp())
    gw(gr(3,2),1,gr(gr(3,2),1)+1)
    gw(3,2,0)
    gw(6,2,gr(1,2))
    sa(0)
    return 9
def _9():
    sa(gr(6,2)-1)
    gw(6,2,gr(6,2)-1)
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48);

    sa(sp()+sp());


    return (16)if((gr(6,2))!=0)else(10)
def _10():
    gw(0,2,3)
    sa(sr());
    sa(sr());
    sa((1)if(sr()<=2)else(0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),2))

    sa(sp()+sp());


    return (13)if(sp()!=0)else(11)
def _11():
    gw(3,2,gr(3,2)+1)
    sp();
    return 12
def _12():
    sp();
    return 4
def _13():
    return (15)if(sr()<=((gr(0,2)-2)*(gr(0,2)-2)))else(14)
def _14():
    sa(sr());
    sa(gr(0,2))
    gw(0,2,gr(0,2)+1)
    v0=sp()
    sa(tm(sp(),v0))


    return (13)if(sp()!=0)else(11)
def _15():
    sp();
    print(sp(),end="",flush=True)
    return 18
def _16():
    sa(sp()*10);
    return 9
def _17():
    gw(4,2,gr(gr(3,2),1))
    return 8
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17]
c=0
while c<18:
    c=m[c]()
