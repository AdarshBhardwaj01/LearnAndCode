public class ATMDeviceController {

    public void withdraw(String accountId, double amount) {
        try {
            performWithdrawal(accountId, amount);
        } catch (ATMException e) {
            logError(e);
            throw e;
        }
    }

    private void performWithdrawal(String accountId, double amount) {
        DeviceHandle handle = getValidHandle();
        DeviceRecord record = getActiveDeviceRecord(handle);

        ensureDeviceConnected(record);
        ensureSufficientBalance(accountId, amount);

        dispenseCash(handle, amount);
    }

    private DeviceHandle getValidHandle() {
        DeviceHandle handle = getHandle(DEV1);

        if (handle == DeviceHandle.INVALID) {
            throw new InvalidDeviceException(
                "ATM withdrawal aborted: invalid device handle"
            );
        }

        return handle;
    }

    private DeviceRecord getActiveDeviceRecord(DeviceHandle handle) {
        DeviceRecord record = retrieveDeviceRecord(handle);

        if (record.getStatus() == DEVICE_SUSPENDED) {
            throw new DeviceLockedException(
                "ATM withdrawal aborted: device is suspended"
            );
        }

        return record;
    }

    private void ensureDeviceConnected(DeviceRecord record) {
        if (record.getWifiConnection() != WIFI_CONNECTED) {
            throw new NetworkConnectionException(
                "ATM withdrawal aborted: network connection unavailable"
            );
        }
    }

    private void ensureSufficientBalance(String accountId, double amount) {
        if (getBalance(accountId) < amount) {
            throw new InsufficientFundsException(
                "ATM withdrawal aborted: insufficient balance in account " + accountId
            );
        }
    }

    private void logError(Exception e) {
        System.err.println("ERROR: " + e.getMessage());
    }
}