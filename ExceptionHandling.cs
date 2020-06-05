//Arithmatic Exception
try
{
  var result = 5 / 0;
}
catch(DivideByZeroException ex)
{
  //code
}
catch(ArithmaticException ex)
{
  //code
}
catch(Exception ex)
{
  //code
}

//Stream Reader Exception
//In stream reader we need to dispose memory manually after use 
StreamReader streamReader = null;
try
{
  streamReader = new Streamreader(@"c:\apple.zip");
  var content = streamreader.ReadToEnd()
}
finally
{
  if (streamReader != null)
    streamReader.Dispose();
}

//OR

//Here, using statement is use and dont need to dispose allocated memory when using statement use.
try
{
  using(streamReader = new Streamreader(@"c:\apple.zip"))
  {
      var content = streamreader.ReadToEnd()
  }
}
