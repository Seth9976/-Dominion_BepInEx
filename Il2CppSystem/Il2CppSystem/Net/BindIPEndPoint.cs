using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000FF RID: 255
	public sealed class BindIPEndPoint : MulticastDelegate
	{
		// Token: 0x06000EF9 RID: 3833 RVA: 0x00048A40 File Offset: 0x00046C40
		// Note: this type is marked as 'beforefieldinit'.
		static BindIPEndPoint()
		{
			Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "BindIPEndPoint");
			BindIPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr, 100665387);
			BindIPEndPoint.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IPEndPoint_ServicePoint_IPEndPoint_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr, 100665388);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00048A90 File Offset: 0x00046C90
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BindIPEndPoint(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindIPEndPoint>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindIPEndPoint.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00048AEC File Offset: 0x00046CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49750, RefRangeEnd = 49751, XrefRangeStart = 49750, XrefRangeEnd = 49750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(servicePoint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteEndPoint);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref retryCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BindIPEndPoint.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IPEndPoint_ServicePoint_IPEndPoint_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPEndPoint>(intPtr3) : null;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00007E8B File Offset: 0x0000608B
		public BindIPEndPoint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00007E94 File Offset: 0x00006094
		public static implicit operator BindIPEndPoint(Func<ServicePoint, IPEndPoint, int, IPEndPoint> A_0)
		{
			return DelegateSupport.ConvertDelegate<BindIPEndPoint>(A_0);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00007E9C File Offset: 0x0000609C
		public static BindIPEndPoint operator +(BindIPEndPoint A_0, BindIPEndPoint A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<BindIPEndPoint>();
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00007EAA File Offset: 0x000060AA
		public static BindIPEndPoint operator -(BindIPEndPoint A_0, BindIPEndPoint A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<BindIPEndPoint>();
			}
			return delegate2;
		}

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IPEndPoint_ServicePoint_IPEndPoint_Int32_0;
	}
}
