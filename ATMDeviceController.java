public class ATMDeviceController {

    public void withdraw(String accountId, double amount) {

        DeviceHandle handle = getHandle(DEV1);

        if (handle == DeviceHandle.INVALID) {
            throw new InvalidDeviceException(
                "ATM withdrawal failed: invalid device handle"
            );
        }

        DeviceRecord record = retrieveDeviceRecord(handle);

        if (record.getStatus() == DEVICE_SUSPENDED) {
            throw new DeviceLockedException(
                "ATM withdrawal failed: device is suspended"
            );
        }

        if (record.getWifiConnection() != WIFI_CONNECTED) {
            throw new NetworkConnectionException(
                "ATM withdrawal failed: network connection unavailable"
            );
        }

        if (getBalance(accountId) < amount) {
            throw new InsufficientFundsException(
                "ATM withdrawal failed: insufficient balance in account " + accountId
            );
        }

        dispenseCash(handle, amount);
    }
}