#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABADtkM0KwjAQhF+l4i1LZLZV/EGCTxJ722tOOfXh3WCNSBtQ8LhzyWSHfJkkd38V1mQ0oxnNaEYzWpsWvmXlVhDaCSDsGSLFFC/0dCkHBhIzUtCWsj/3"
  + "jnTu3VQODWU7buO9EliTd5UEJhZwAryuuNYoalTGpOlHsOjGc5NlFKubNl03Uu8OJypPALe/56W1G287ubjj0C7zgx7G7Dw7OggAAA==")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<78 and y<27):
        return g[y*78 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<78 and y<27):
        g[y*78 + x]=v;
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
def _0():
    gw(0,0,1)
    gw(1,0,1)
    return 1
def _1():
    return (3)if((gr(0,0)*(22-gr(1,0)))!=0)else(2)
def _2():
    gw(0,0,gr(0,0)+gr(1,0))
    gw(1,0,1)
    return 1
def _3():
    return (4)if(gr(0,0)>21)else(6)
def _4():
    gw(0,0,gr(0,0)-1)
    gw(1,0,gr(1,0)+1)

    return (5)if((gr(1,0)+gr(0,0))>42)else(1)
def _5():
    print(gr(21,21),end=" ",flush=True)
    return 9
def _6():
    return (8)if(((gr(0,0)-1)*(gr(1,0)-1))!=0)else(7)
def _7():
    gw(gr(0,0),gr(1,0),1)
    return 4
def _8():
    gw(gr(0,0),gr(1,0),gr(gr(0,0)-1,gr(1,0))+gr(gr(0,0),gr(1,0)-1))
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8]
c=0
while c<9:
    c=m[c]()
