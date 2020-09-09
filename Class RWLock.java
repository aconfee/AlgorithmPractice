Class RWLock {
	private bool writer = false;
	private readers = 0;
	private Lock readLock = new Lock();
	private Lock writeLock = new Lock();

	public void readLock()
	{
		if(!writer)
		{
			this.readers++;
            this.readLock.lock();
		}
	}

	public void readUnlock()
	{
		if(readers > 0)
        {
			readers--;
        }

        if(readers == 0)
        {
            readLock.unlock();
        }
	}

	public void writeLock()
	{
		if(readers == 0 && !writer)
		{
			writer = true;
			writeLock.lock();
		}
	}

	public void writeUnlock()
	{
		writer = false;
        writeLock.unlock();
	}
}
