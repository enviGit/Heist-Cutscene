filename=$(basename `git rev-parse --show-toplevel`).zip
echo Packing repo to $filename
rm -f $filename
7z a -bsp1 -xr0\!\.git -xr0\!Library -xr0\!Logs $filename .
echo done!
start firefox "https://s3.console.aws.amazon.com/s3/buckets/studenci?region=eu-west-1&tab=objects"
read