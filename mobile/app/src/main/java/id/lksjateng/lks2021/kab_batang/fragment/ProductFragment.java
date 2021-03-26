package id.lksjateng.lks2021.kab_batang.fragment;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import id.lksjateng.lks2021.kab_batang.R;
import id.lksjateng.lks2021.kab_batang.util.Request;

public class ProductFragment extends Fragment {

    View root;
    LinearLayout list;

    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        root = inflater.inflate(R.layout.fragment_product, container, false);

        list = root.findViewById(R.id.product_list);

        return root;
    }

    @Override
    public void onResume() {
        super.onResume();

        list.removeAllViews();

        Request.get("Products", "application/json", false).thenAccept(res -> {
            if (res.code < 400) {
                try {
                    JSONArray array = res.asJsonArray();
                    for (int i = 0; i < array.length(); i++) {
                        JSONObject obj = array.getJSONObject(i);
                        String prodName = obj.getString("name");
                        String prodType = obj.getString("type");
                        String prodPrice = "Rp. " + obj.getDouble("price");
                        root.post(() -> {
                            View product = View.inflate(getActivity(), R.layout.layout_product, null);
                            TextView name = product.findViewById(R.id.product_name);
                            TextView price = product.findViewById(R.id.product_price);
                            TextView type = product.findViewById(R.id.product_type);
                            name.setText(prodName);
                            price.setText(prodPrice);
                            type.setText(prodType);
                            list.addView(product, list.getWidth(), (int) (60 * getContext().getResources().getDisplayMetrics().density));
                        });
                    }
                    root.postInvalidate();
                } catch (JSONException e) {
                    e.printStackTrace();
                }
            }
        });
    }

}