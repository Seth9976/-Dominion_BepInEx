using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x020001ED RID: 493
	public sealed class GraphicsBuffer
	{
		// Token: 0x06001E37 RID: 7735 RVA: 0x000641D8 File Offset: 0x000623D8
		public ~GraphicsBuffer()
		{
			this.Dispose(false);
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0001114E File Offset: 0x0000F34E
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00011160 File Offset: 0x0000F360
		public void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x0006420C File Offset: 0x0006240C
		public static bool RequiresCompute(GraphicsBuffer.Target target)
		{
			int num = 3;
			return (target & (GraphicsBuffer.Target)num) != target;
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0001116D File Offset: 0x0000F36D
		public static IntPtr InitBuffer(GraphicsBuffer.Target target, int count, int stride)
		{
			return GraphicsBuffer.InitBufferDelegateField(target, count, stride);
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x0001117C File Offset: 0x0000F37C
		public static void DestroyBuffer(GraphicsBuffer buf)
		{
			GraphicsBuffer.DestroyBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtr(buf));
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0001118E File Offset: 0x0000F38E
		public void Release()
		{
			this.Dispose();
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00011198 File Offset: 0x0000F398
		public bool IsValid()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x000111A5 File Offset: 0x0000F3A5
		public int count
		{
			get
			{
				return GraphicsBuffer.get_countDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x000111B7 File Offset: 0x0000F3B7
		public int stride
		{
			get
			{
				return GraphicsBuffer.get_strideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0006422C File Offset: 0x0006242C
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
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalSetData(data, 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00064294 File Offset: 0x00062494
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
				throw new ArgumentException(String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), 0, 0, NoAllocHelpers.SafeLength<T>(data), Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x000111C9 File Offset: 0x0000F3C9
		public void SetData<T>(Unity.Collections.NativeArray<T> data) where T : struct
		{
			this.InternalSetNativeData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), 0, 0, data.Length, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00064308 File Offset: 0x00062508
		public void SetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count)
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsArrayBlittable(data);
			if (flag2)
			{
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.SetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetData(data, managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x000643AC File Offset: 0x000625AC
		public void SetData<T>(List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = data == null;
			if (flag)
			{
				throw new ArgumentNullException("data");
			}
			bool flag2 = !Unity.Collections.LowLevel.Unsafe.UnsafeUtility.IsGenericListBlittable<T>();
			if (flag2)
			{
				throw new ArgumentException(String.Format("List<{0}> passed to GraphicsBuffer.SetData(List<>) must be blittable.\n{1}", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForGenericListNonBlittable<T>()));
			}
			bool flag3 = managedBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Count;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (managedBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", managedBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetData(NoAllocHelpers.ExtractArrayFromList(data), managedBufferStartIndex, graphicsBufferStartIndex, count, Marshal.SizeOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0006445C File Offset: 0x0006265C
		public void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count) where T : struct
		{
			bool flag = nativeBufferStartIndex < 0 || graphicsBufferStartIndex < 0 || count < 0 || nativeBufferStartIndex + count > data.Length;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count arguments (nativeBufferStartIndex:{0} graphicsBufferStartIndex:{1} count:{2})", nativeBufferStartIndex, graphicsBufferStartIndex, count));
			}
			this.InternalSetNativeData((IntPtr)data.GetUnsafeReadOnlyPtr<T>(), nativeBufferStartIndex, graphicsBufferStartIndex, count, Unity.Collections.LowLevel.Unsafe.UnsafeUtility.SizeOf<T>());
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x000111EC File Offset: 0x0000F3EC
		public void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			GraphicsBuffer.InternalSetNativeDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), data, nativeBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00011205 File Offset: 0x0000F405
		public void InternalSetData(Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
			GraphicsBuffer.InternalSetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, graphicsBufferStartIndex, count, elemSize);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000644CC File Offset: 0x000626CC
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
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			this.InternalGetData(data, 0, 0, data.Length, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00064534 File Offset: 0x00062734
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
				throw new ArgumentException(String.Format("Array passed to GraphicsBuffer.GetData(array) must be blittable.\n{0}", Unity.Collections.LowLevel.Unsafe.UnsafeUtility.GetReasonForArrayNonBlittable(data)));
			}
			bool flag3 = managedBufferStartIndex < 0 || computeBufferStartIndex < 0 || count < 0 || managedBufferStartIndex + count > data.Length;
			if (flag3)
			{
				throw new ArgumentOutOfRangeException(String.Format("Bad indices/count argument (managedBufferStartIndex:{0} computeBufferStartIndex:{1} count:{2})", managedBufferStartIndex, computeBufferStartIndex, count));
			}
			this.InternalGetData(data, managedBufferStartIndex, computeBufferStartIndex, count, Marshal.SizeOf(data.GetType().GetElementType()));
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00011223 File Offset: 0x0000F423
		public void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize)
		{
			GraphicsBuffer.InternalGetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(data), managedBufferStartIndex, computeBufferStartIndex, count, elemSize);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00011241 File Offset: 0x0000F441
		public IntPtr GetNativeBufferPtr()
		{
			return GraphicsBuffer.GetNativeBufferPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00011253 File Offset: 0x0000F453
		public void SetName(string name)
		{
			GraphicsBuffer.SetNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(name));
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0001126B File Offset: 0x0000F46B
		public void SetCounterValue(uint counterValue)
		{
			GraphicsBuffer.SetCounterValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), counterValue);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x0001127E File Offset: 0x0000F47E
		public static void CopyCountCC(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCCDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00011297 File Offset: 0x0000F497
		public static void CopyCountGC(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGCDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x000112B0 File Offset: 0x0000F4B0
		public static void CopyCountCG(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x000112C9 File Offset: 0x0000F4C9
		public static void CopyCountGG(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), dstOffsetBytes);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000112E2 File Offset: 0x0000F4E2
		public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000112EE File Offset: 0x0000F4EE
		public static void CopyCount(GraphicsBuffer src, ComputeBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGC(src, dst, dstOffsetBytes);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000112FA File Offset: 0x0000F4FA
		public static void CopyCount(ComputeBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountCG(src, dst, dstOffsetBytes);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00011306 File Offset: 0x0000F506
		public static void CopyCount(GraphicsBuffer src, GraphicsBuffer dst, int dstOffsetBytes)
		{
			GraphicsBuffer.CopyCountGG(src, dst, dstOffsetBytes);
		}

		// Token: 0x0400176F RID: 5999
		private static readonly GraphicsBuffer.InitBufferDelegate InitBufferDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InitBufferDelegate>("UnityEngine.GraphicsBuffer::InitBuffer");

		// Token: 0x04001770 RID: 6000
		private static readonly GraphicsBuffer.DestroyBufferDelegate DestroyBufferDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.DestroyBufferDelegate>("UnityEngine.GraphicsBuffer::DestroyBuffer");

		// Token: 0x04001771 RID: 6001
		private static readonly GraphicsBuffer.get_countDelegate get_countDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_countDelegate>("UnityEngine.GraphicsBuffer::get_count");

		// Token: 0x04001772 RID: 6002
		private static readonly GraphicsBuffer.get_strideDelegate get_strideDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.get_strideDelegate>("UnityEngine.GraphicsBuffer::get_stride");

		// Token: 0x04001773 RID: 6003
		private static readonly GraphicsBuffer.InternalSetNativeDataDelegate InternalSetNativeDataDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalSetNativeDataDelegate>("UnityEngine.GraphicsBuffer::InternalSetNativeData");

		// Token: 0x04001774 RID: 6004
		private static readonly GraphicsBuffer.InternalSetDataDelegate InternalSetDataDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalSetDataDelegate>("UnityEngine.GraphicsBuffer::InternalSetData");

		// Token: 0x04001775 RID: 6005
		private static readonly GraphicsBuffer.InternalGetDataDelegate InternalGetDataDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.InternalGetDataDelegate>("UnityEngine.GraphicsBuffer::InternalGetData");

		// Token: 0x04001776 RID: 6006
		private static readonly GraphicsBuffer.GetNativeBufferPtrDelegate GetNativeBufferPtrDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.GetNativeBufferPtrDelegate>("UnityEngine.GraphicsBuffer::GetNativeBufferPtr");

		// Token: 0x04001777 RID: 6007
		private static readonly GraphicsBuffer.SetNameDelegate SetNameDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.SetNameDelegate>("UnityEngine.GraphicsBuffer::SetName");

		// Token: 0x04001778 RID: 6008
		private static readonly GraphicsBuffer.SetCounterValueDelegate SetCounterValueDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.SetCounterValueDelegate>("UnityEngine.GraphicsBuffer::SetCounterValue");

		// Token: 0x04001779 RID: 6009
		private static readonly GraphicsBuffer.CopyCountCCDelegate CopyCountCCDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountCCDelegate>("UnityEngine.GraphicsBuffer::CopyCountCC");

		// Token: 0x0400177A RID: 6010
		private static readonly GraphicsBuffer.CopyCountGCDelegate CopyCountGCDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountGCDelegate>("UnityEngine.GraphicsBuffer::CopyCountGC");

		// Token: 0x0400177B RID: 6011
		private static readonly GraphicsBuffer.CopyCountCGDelegate CopyCountCGDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountCGDelegate>("UnityEngine.GraphicsBuffer::CopyCountCG");

		// Token: 0x0400177C RID: 6012
		private static readonly GraphicsBuffer.CopyCountGGDelegate CopyCountGGDelegateField = IL2CPP.ResolveICall<GraphicsBuffer.CopyCountGGDelegate>("UnityEngine.GraphicsBuffer::CopyCountGG");

		// Token: 0x02000B89 RID: 2953
		public enum Target
		{
			// Token: 0x04001D95 RID: 7573
			Vertex = 1,
			// Token: 0x04001D96 RID: 7574
			Index,
			// Token: 0x04001D97 RID: 7575
			Structured = 16,
			// Token: 0x04001D98 RID: 7576
			Raw = 32,
			// Token: 0x04001D99 RID: 7577
			Append = 64,
			// Token: 0x04001D9A RID: 7578
			Counter = 128,
			// Token: 0x04001D9B RID: 7579
			IndirectArguments = 256,
			// Token: 0x04001D9C RID: 7580
			Constant = 512
		}

		// Token: 0x02000B8A RID: 2954
		// (Invoke) Token: 0x06003512 RID: 13586
		private delegate IntPtr InitBufferDelegate(GraphicsBuffer.Target target, int count, int stride);

		// Token: 0x02000B8B RID: 2955
		// (Invoke) Token: 0x06003514 RID: 13588
		private delegate void DestroyBufferDelegate(IntPtr buf);

		// Token: 0x02000B8C RID: 2956
		// (Invoke) Token: 0x06003516 RID: 13590
		private delegate int get_countDelegate(IntPtr @this);

		// Token: 0x02000B8D RID: 2957
		// (Invoke) Token: 0x06003518 RID: 13592
		private delegate int get_strideDelegate(IntPtr @this);

		// Token: 0x02000B8E RID: 2958
		// (Invoke) Token: 0x0600351A RID: 13594
		private delegate void InternalSetNativeDataDelegate(IntPtr @this, IntPtr data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x02000B8F RID: 2959
		// (Invoke) Token: 0x0600351C RID: 13596
		private delegate void InternalSetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);

		// Token: 0x02000B90 RID: 2960
		// (Invoke) Token: 0x0600351E RID: 13598
		private delegate void InternalGetDataDelegate(IntPtr @this, IntPtr data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x02000B91 RID: 2961
		// (Invoke) Token: 0x06003520 RID: 13600
		private delegate IntPtr GetNativeBufferPtrDelegate(IntPtr @this);

		// Token: 0x02000B92 RID: 2962
		// (Invoke) Token: 0x06003522 RID: 13602
		private delegate void SetNameDelegate(IntPtr @this, IntPtr name);

		// Token: 0x02000B93 RID: 2963
		// (Invoke) Token: 0x06003524 RID: 13604
		private delegate void SetCounterValueDelegate(IntPtr @this, uint counterValue);

		// Token: 0x02000B94 RID: 2964
		// (Invoke) Token: 0x06003526 RID: 13606
		private delegate void CopyCountCCDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000B95 RID: 2965
		// (Invoke) Token: 0x06003528 RID: 13608
		private delegate void CopyCountGCDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000B96 RID: 2966
		// (Invoke) Token: 0x0600352A RID: 13610
		private delegate void CopyCountCGDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);

		// Token: 0x02000B97 RID: 2967
		// (Invoke) Token: 0x0600352C RID: 13612
		private delegate void CopyCountGGDelegate(IntPtr src, IntPtr dst, int dstOffsetBytes);
	}
}
