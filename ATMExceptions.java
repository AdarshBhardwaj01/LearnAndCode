class ATMException extends RuntimeException {
    public ATMException(String message) {
        super(message);
    }
}

class DeviceLockedException extends ATMException {
    public DeviceLockedException(String message) {
        super(message);
    }
}

class InsufficientFundsException extends ATMException {
    public InsufficientFundsException(String message) {
        super(message);
    }
}

class NetworkConnectionException extends ATMException {
    public NetworkConnectionException(String message) {
        super(message);
    }
}

class InvalidDeviceException extends ATMException {
    public InvalidDeviceException(String message) {
        super(message);
    }
}