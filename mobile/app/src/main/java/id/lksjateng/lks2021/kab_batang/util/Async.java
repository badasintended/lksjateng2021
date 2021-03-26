package id.lksjateng.lks2021.kab_batang.util;

import java.util.concurrent.CompletableFuture;
import java.util.function.Supplier;

public class Async {

    public static <T> CompletableFuture<T> async(Supplier<T> supplier) {
        return CompletableFuture.supplyAsync(supplier);
    }

}
