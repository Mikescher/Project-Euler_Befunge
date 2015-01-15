# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABACNksFqwzAMhl9FzZpLTYYktxmIYPYYOwSTm646+eSHn9zQkZaQTmAhWd8fS3bKz93gnZV/cue3xGrpC4DYAJPgTCbSURfKgaAOyiSBDGeYdvrzZRzpvFM76CKykh4d2wjuKxTj65QaTcG3yrYupEtdM2w+52io7G6iB5cfPLYjraQrK2pszqNsf5wPEcjFa7qZxjuI+DxdGWVwdrwEuN0mNB79jjbI9+eaJPZ+OuyGMLLWvTFfn+3DRZIishUP0O9gkMsCp1fxXZdOM/cQam+MgUQZZfcV8sLilaNfJG/ip2/8AoE9XKOoAgAA"
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
def rd():
    return bool(random.getrandbits(1))
def td(a,b):
    return bool(random.getrandbits(1))
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
    return (24)if(sp()!=0)else(8)
def _1():
    return (11)if(sp()!=0)else(10)
def _2():
    return (12)if(sp()!=0)else(23)
def _3():
    return (22)if(sp()!=0)else(15)
def _4():
    return (16)if(sp()!=0)else(21)
def _5():
    return (20)if(sp()!=0)else(17)
def _6():
    return (16)if(sp()!=0)else(18)
def _7():
    gw(1,2,7)
    gw(0,1,0)
    gw(0,0,49)
    sp()
    sa(1)
    sa((1)-(gr(1,2)))
    return 0
def _8():
    gw(3,2,1)
    sp()
    return 9
def _9():
    sa((1)if((gr(3,2))>(gr(gr(3,2),1)))else(0))
    return 1
def _10():
    gw(gr(3,2),1,0)
    gw(3,2,(gr(3,2))+(1))
    return 9
def _11():
    sa(tm(gr(3,2),2))
    return 2
def _12():
    gw(4,2,gr(gr(3,2),1))
    return 13
def _13():
    sa(gr(gr(4,2),0))
    gw(gr(4,2),0,gr(gr(3,2),0))
    gw(gr(3,2),0,sp())
    gw(gr(3,2),1,(gr(gr(3,2),1))+(1))
    gw(3,2,0)
    gw(6,2,gr(1,2))
    sa(0)
    return 14
def _14():
    sa((gr(6,2))-(1))
    gw(6,2,(gr(6,2))-(1))
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(48)
    v0=sp()
    sa(sp()-v0)
    sa(sp()+sp());
    sa(gr(6,2))
    return 3
def _15():
    gw(0,2,3)
    sa(sr())
    sa(sr())
    sa(sr())
    sa(2)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if(sp()!=0)else(1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sp()+sp());
    return 4
def _16():
    sa(sr())
    sa(((gr(0,2))-(2))*((gr(0,2))-(2)))
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    sa((0)if(sp()!=0)else(1))
    return 5
def _17():
    sa(sr())
    sa(gr(0,2))
    gw(0,2,(gr(0,2))+(1))
    v0=sp()
    sa(tm(sp(),v0))
    return 6
def _18():
    gw(3,2,(gr(3,2))+(1))
    sp()
    return 19
def _19():
    sp()
    return 9
def _20():
    sp()
    print(sp(),end="",flush=True)
    return 25
def _21():
    gw(3,2,(gr(3,2))+(1))
    sp()
    return 19
def _22():
    sa(10)
    sa(sp()*sp());
    return 14
def _23():
    gw(4,2,0)
    return 13
def _24():
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    sa(sr())
    sa(49)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(1)
    sa(sp()+sp());
    sa(sr())
    sa(gr(1,2))
    v0=sp()
    sa(sp()-v0)
    return 0
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24]
c=7
while c<25:
    c=m[c]()