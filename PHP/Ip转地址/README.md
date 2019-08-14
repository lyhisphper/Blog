
## 使用

    public function testGetlocation()
    {
        $ip  = new IpLocationService();
        $res = $ip->getlocation('47.100.101.79');
        var_dump($res);
    }
    
## 输出
```
array(7) {
  'ip' =>
  string(13) "47.100.101.79"
  'beginip' =>
  string(10) "47.100.0.0"
  'endip' =>
  string(14) "47.103.255.255"
  'country' =>
  string(9) "上海市"
  'area' =>
  string(9) "阿里云"
  'province' =>
  string(9) "上海市"
  'city' =>
  string(9) "上海市"
}
```
