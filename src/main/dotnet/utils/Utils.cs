
public static class Utils {

    public static Option<byte[]> Load(string filename) {
        // final InputStream is = Utils.class.getResourceAsStream(filename);
        // byte[] b = null;
        // try (DataInputStream in = new DataInputStream(new BufferedInputStream(is))) {
        //     b = new byte[is.available()];
        //     in.read(b);

        // } catch (NullPointerException | IOException e) {
        //     System.out.println("Could not load: " + filename);
        //     System.out.println("Please check the spelling");
        // }
        // return Optional.ofNullable(b);
        return None.Value;
    }

    public static int GetBitValue(int value, int bitIndex) {
        //return value & (0x80 >> bitIndex);
        return 0;
    }

    public static string GetHex(int value) {
        // return Integer.toHexString(value);
        return string.Empty;
    }
}
