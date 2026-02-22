using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x0200023B RID: 571
	public sealed class ComputeBuffer
	{
		// Token: 0x06001F13 RID: 7955 RVA: 0x00065980 File Offset: 0x00063B80
		public ~ComputeBuffer()
		{
			this.Dispose(false);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00011D8E File Offset: 0x0000FF8E
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00011DA0 File Offset: 0x0000FFA0
		public void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00011DAD File Offset: 0x0000FFAD
		public static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage)
		{
			return ComputeBuffer.InitBufferDelegateField(count, stride, type, usage);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00011DBD File Offset: 0x0000FFBD
		public static void DestroyBuffer(ComputeBuffer buf)
		{
			ComputeBuffer.DestroyBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buf));
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00011DCF File Offset: 0x0000FFCF
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00011DD9 File Offset: 0x0000FFD9
		public static bool IsValidBuffer(ComputeBuffer buf)
		{
			return ComputeBuffer.IsValidBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buf));
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00011DEB File Offset: 0x0000FFEB
		public bool IsValid()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00011DF8 File Offset: 0x0000FFF8
		public int count
		{
			get
			{
				return ComputeBuffer.get_countDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00011E0A File Offset: 0x0001000A
		public int stride
		{
			get
			{
				return ComputeBuffer.get_strideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x00011E1C File Offset: 0x0001001C
		public ComputeBufferMode usage
		{
			get
			{
				return ComputeBuffer.get_usageDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x000659B4 File Offset: 0x00063BB4
		public void SetData(Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalSetData(data, 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00065A1C File Offset: 0x00063C1C
		public void SetData<T>(List<T> data) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00011E2E File Offset: 0x0001002E
		public void SetData<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			this.InternalSetNativeData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00065A90 File Offset: 0x00063C90
		public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalSetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00065B34 File Offset: 0x00063D34
		public void SetData<T>(List<T> data, int managedBufferStartIndex, int computeBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to ComputeBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00065BE4 File Offset: 0x00063DE4
		public void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) where T : struct
		{
			bool flag = nativeBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || nativeBufferStartIndex + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (nativeBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", nativeBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalSetNativeData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), nativeBufferStartIndex, computeBufferStartIndex, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00011E51 File Offset: 0x00010051
		public void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			ComputeBuffer.InternalSetNativeDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, nativeBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00011E6A File Offset: 0x0001006A
		public void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			ComputeBuffer.InternalSetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00065C54 File Offset: 0x00063E54
		public void GetData(Array data)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalGetData(data, 0, 0, data.Length, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00065CBC File Offset: 0x00063EBC
		public void GetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to ComputeBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00011E88 File Offset: 0x00010088
		public void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			ComputeBuffer.InternalGetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00011EA6 File Offset: 0x000100A6
		public unsafe void* BeginBufferWrite([Optional] int offset, [Optional] int size)
		{
			return ComputeBuffer.BeginBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), offset, size);
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00011EBA File Offset: 0x000100BA
		public Unity.Collections.NativeArray<T> BeginWrite<T>(int computeBufferStartIndex, int count) where T : struct
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00011EC7 File Offset: 0x000100C7
		public void EndBufferWrite([Optional] int bytesWritten)
		{
			ComputeBuffer.EndBufferWriteDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), bytesWritten);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00065D60 File Offset: 0x00063F60
		public void EndWrite<T>(int countWritten) where T : struct
		{
			bool flag = countWritten < 0;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (countWritten:{0})", countWritten));
			}
			int num = Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>();
			this.EndBufferWrite(countWritten * num);
		}

		// Token: 0x17000691 RID: 1681
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x00011EDA File Offset: 0x000100DA
		public string name
		{
			set
			{
				this.SetName(value);
			}
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00011EE5 File Offset: 0x000100E5
		public void SetName(string name)
		{
			ComputeBuffer.SetNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00011EFD File Offset: 0x000100FD
		public void SetCounterValue(uint counterValue)
		{
			ComputeBuffer.SetCounterValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), counterValue);
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00011F10 File Offset: 0x00010110
		public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			ComputeBuffer.CopyCountDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00011F29 File Offset: 0x00010129
		public IntPtr GetNativeBufferPtr()
		{
			return ComputeBuffer.GetNativeBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04001897 RID: 6295
		private static readonly ComputeBuffer.InitBufferDelegate InitBufferDelegateField = IL2CPP.ResolveICall<ComputeBuffer.InitBufferDelegate>("UnityEngine.ComputeBuffer::InitBuffer");

		// Token: 0x04001898 RID: 6296
		private static readonly ComputeBuffer.DestroyBufferDelegate DestroyBufferDelegateField = IL2CPP.ResolveICall<ComputeBuffer.DestroyBufferDelegate>("UnityEngine.ComputeBuffer::DestroyBuffer");

		// Token: 0x04001899 RID: 6297
		private static readonly ComputeBuffer.IsValidBufferDelegate IsValidBufferDelegateField = IL2CPP.ResolveICall<ComputeBuffer.IsValidBufferDelegate>("UnityEngine.ComputeBuffer::IsValidBuffer");

		// Token: 0x0400189A RID: 6298
		private static readonly ComputeBuffer.get_countDelegate get_countDelegateField = IL2CPP.ResolveICall<ComputeBuffer.get_countDelegate>("UnityEngine.ComputeBuffer::get_count");

		// Token: 0x0400189B RID: 6299
		private static readonly ComputeBuffer.get_strideDelegate get_strideDelegateField = IL2CPP.ResolveICall<ComputeBuffer.get_strideDelegate>("UnityEngine.ComputeBuffer::get_stride");

		// Token: 0x0400189C RID: 6300
		private static readonly ComputeBuffer.get_usageDelegate get_usageDelegateField = IL2CPP.ResolveICall<ComputeBuffer.get_usageDelegate>("UnityEngine.ComputeBuffer::get_usage");

		// Token: 0x0400189D RID: 6301
		private static readonly ComputeBuffer.InternalSetNativeDataDelegate InternalSetNativeDataDelegateField = IL2CPP.ResolveICall<ComputeBuffer.InternalSetNativeDataDelegate>("UnityEngine.ComputeBuffer::InternalSetNativeData");

		// Token: 0x0400189E RID: 6302
		private static readonly ComputeBuffer.InternalSetDataDelegate InternalSetDataDelegateField = IL2CPP.ResolveICall<ComputeBuffer.InternalSetDataDelegate>("UnityEngine.ComputeBuffer::InternalSetData");

		// Token: 0x0400189F RID: 6303
		private static readonly ComputeBuffer.InternalGetDataDelegate InternalGetDataDelegateField = IL2CPP.ResolveICall<ComputeBuffer.InternalGetDataDelegate>("UnityEngine.ComputeBuffer::InternalGetData");

		// Token: 0x040018A0 RID: 6304
		private static readonly ComputeBuffer.BeginBufferWriteDelegate BeginBufferWriteDelegateField = IL2CPP.ResolveICall<ComputeBuffer.BeginBufferWriteDelegate>("UnityEngine.ComputeBuffer::BeginBufferWrite");

		// Token: 0x040018A1 RID: 6305
		private static readonly ComputeBuffer.EndBufferWriteDelegate EndBufferWriteDelegateField = IL2CPP.ResolveICall<ComputeBuffer.EndBufferWriteDelegate>("UnityEngine.ComputeBuffer::EndBufferWrite");

		// Token: 0x040018A2 RID: 6306
		private static readonly ComputeBuffer.SetNameDelegate SetNameDelegateField = IL2CPP.ResolveICall<ComputeBuffer.SetNameDelegate>("UnityEngine.ComputeBuffer::SetName");

		// Token: 0x040018A3 RID: 6307
		private static readonly ComputeBuffer.SetCounterValueDelegate SetCounterValueDelegateField = IL2CPP.ResolveICall<ComputeBuffer.SetCounterValueDelegate>("UnityEngine.ComputeBuffer::SetCounterValue");

		// Token: 0x040018A4 RID: 6308
		private static readonly ComputeBuffer.CopyCountDelegate CopyCountDelegateField = IL2CPP.ResolveICall<ComputeBuffer.CopyCountDelegate>("UnityEngine.ComputeBuffer::CopyCount");

		// Token: 0x040018A5 RID: 6309
		private static readonly ComputeBuffer.GetNativeBufferPtrDelegate GetNativeBufferPtrDelegateField = IL2CPP.ResolveICall<ComputeBuffer.GetNativeBufferPtrDelegate>("UnityEngine.ComputeBuffer::GetNativeBufferPtr");

		// Token: 0x02000C0E RID: 3086
		// (Invoke) Token: 0x0600360A RID: 13834
		private delegate IntPtr InitBufferDelegate(int count, int stride, ComputeBufferType type, ComputeBufferMode usage);

		// Token: 0x02000C0F RID: 3087
		// (Invoke) Token: 0x0600360C RID: 13836
		private delegate void DestroyBufferDelegate(IntPtr buf);

		// Token: 0x02000C10 RID: 3088
		// (Invoke) Token: 0x0600360E RID: 13838
		private delegate bool IsValidBufferDelegate(IntPtr buf);

		// Token: 0x02000C11 RID: 3089
		// (Invoke) Token: 0x06003610 RID: 13840
		private delegate int get_countDelegate(IntPtr @this);

		// Token: 0x02000C12 RID: 3090
		// (Invoke) Token: 0x06003612 RID: 13842
		private delegate int get_strideDelegate(IntPtr @this);

		// Token: 0x02000C13 RID: 3091
		// (Invoke) Token: 0x06003614 RID: 13844
		private delegate ComputeBufferMode get_usageDelegate(IntPtr @this);

		// Token: 0x02000C14 RID: 3092
		// (Invoke) Token: 0x06003616 RID: 13846
		private delegate void InternalSetNativeDataDelegate(IntPtr @this, IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x02000C15 RID: 3093
		// (Invoke) Token: 0x06003618 RID: 13848
		private delegate void InternalSetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x02000C16 RID: 3094
		// (Invoke) Token: 0x0600361A RID: 13850
		private delegate void InternalGetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x02000C17 RID: 3095
		// (Invoke) Token: 0x0600361C RID: 13852
		private delegate IntPtr BeginBufferWriteDelegate(IntPtr @this, int offset, int size);

		// Token: 0x02000C18 RID: 3096
		// (Invoke) Token: 0x0600361E RID: 13854
		private delegate void EndBufferWriteDelegate(IntPtr @this, int bytesWritten);

		// Token: 0x02000C19 RID: 3097
		// (Invoke) Token: 0x06003620 RID: 13856
		private delegate void SetNameDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000C1A RID: 3098
		// (Invoke) Token: 0x06003622 RID: 13858
		private delegate void SetCounterValueDelegate(IntPtr @this, uint counterValue);

		// Token: 0x02000C1B RID: 3099
		// (Invoke) Token: 0x06003624 RID: 13860
		private delegate void CopyCountDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000C1C RID: 3100
		// (Invoke) Token: 0x06003626 RID: 13862
		private delegate IntPtr GetNativeBufferPtrDelegate(IntPtr @this);
	}
}
