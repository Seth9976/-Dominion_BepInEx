using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace Il2CppSystem.Net.Security
{
	// Token: 0x02000133 RID: 307
	public class AuthenticatedStream : Stream
	{
		// Token: 0x0600149C RID: 5276 RVA: 0x0005E21C File Offset: 0x0005C41C
		// Note: this type is marked as 'beforefieldinit'.
		static AuthenticatedStream()
		{
			Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "AuthenticatedStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr);
			AuthenticatedStream.NativeFieldInfoPtr__InnerStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, "_InnerStream");
			AuthenticatedStream.NativeFieldInfoPtr__LeaveStreamOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, "_LeaveStreamOpen");
			AuthenticatedStream.NativeMethodInfoPtr__ctor_Protected_Void_Stream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100666192);
			AuthenticatedStream.NativeMethodInfoPtr_get_InnerStream_Protected_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100666193);
			AuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100666194);
			AuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr, 100666195);
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0005E2C4 File Offset: 0x0005C4C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57299, RefRangeEnd = 57303, XrefRangeStart = 57289, XrefRangeEnd = 57299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AuthenticatedStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatedStream.NativeMethodInfoPtr__ctor_Protected_Void_Stream_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600149E RID: 5278 RVA: 0x0005E320 File Offset: 0x0005C520
		public unsafe Stream InnerStream
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AuthenticatedStream.NativeMethodInfoPtr_get_InnerStream_Protected_get_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0005E360 File Offset: 0x0005C560
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 57308, RefRangeEnd = 57312, XrefRangeStart = 57303, XrefRangeEnd = 57308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthenticatedStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x0005E3AC File Offset: 0x0005C5AC
		public unsafe virtual bool IsAuthenticated
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AuthenticatedStream.NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0000A6A4 File Offset: 0x000088A4
		public AuthenticatedStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x0005E3F4 File Offset: 0x0005C5F4
		// (set) Token: 0x060014A3 RID: 5283 RVA: 0x0000A6AD File Offset: 0x000088AD
		public unsafe Stream _InnerStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__InnerStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__InnerStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x0005E424 File Offset: 0x0005C624
		// (set) Token: 0x060014A5 RID: 5285 RVA: 0x0000A6CC File Offset: 0x000088CC
		public unsafe bool _LeaveStreamOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__LeaveStreamOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AuthenticatedStream.NativeFieldInfoPtr__LeaveStreamOpen)) = value;
			}
		}

		// Token: 0x040010A8 RID: 4264
		private static readonly IntPtr NativeFieldInfoPtr__InnerStream;

		// Token: 0x040010A9 RID: 4265
		private static readonly IntPtr NativeFieldInfoPtr__LeaveStreamOpen;

		// Token: 0x040010AA RID: 4266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Stream_Boolean_0;

		// Token: 0x040010AB RID: 4267
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerStream_Protected_get_Stream_0;

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAuthenticated_Public_Abstract_Virtual_New_get_Boolean_0;
	}
}
