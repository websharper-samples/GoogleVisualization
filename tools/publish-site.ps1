# creates build/html
rm -r build -errorAction ignore
$d = mkdir build
$d = mkdir build/html
cp -r WebSharper.GoogleVisualization.Sample/Content build/html/
cp -r WebSharper.GoogleVisualization.Sample/*.jpg build/html/
cp -r WebSharper.GoogleVisualization.Sample/*.css build/html/
cp -r WebSharper.GoogleVisualization.Sample/*.html build/html/
cp -r WebSharper.GoogleVisualization.Sample/*.json build/html/
