# compiled with BefunCompile v1.0.5 (c) 2015
# execute with at least Python3
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
    gw(0,0,1)
    gw(1,0,1)
    return 1
def _1():
    return (2)if(gr(0,0)*(22-gr(1,0)))else(8)
def _2():
    sa((1)if((gr(0,0))>(21))else(0))
    return (3)if(sp()!=0)else(5)
def _3():
    gw(0,0,gr(0,0)-1)
    gw(1,0,gr(1,0)+1)
    sa((0)if(((1)if((gr(1,0)+gr(0,0))>(42))else(0))!=0)else(1))
    return (1)if(sp()!=0)else(4)
def _4():
    print(gr(21,21),end="",flush=True)
    return 9
def _5():
    sa((gr(0,0)-1)*(gr(1,0)-1))
    return (7)if(sp()!=0)else(6)
def _6():
    gw(gr(0,0),gr(1,0),1)
    return 3
def _7():
    gw(gr(0,0),gr(1,0),gr(gr(0,0)-1,gr(1,0))+gr(gr(0,0),gr(1,0)-1))
    return 3
def _8():
    gw(0,0,gr(0,0)+gr(1,0))
    gw(1,0,1)
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8]
c=0
while c<9:
    c=m[c]()