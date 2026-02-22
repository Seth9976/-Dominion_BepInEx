using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000406 RID: 1030
	public class RemotingSurrogateSelector : Object
	{
		// Token: 0x06004102 RID: 16642 RVA: 0x0012CEE0 File Offset: 0x0012B0E0
		// Note: this type is marked as 'beforefieldinit'.
		static RemotingSurrogateSelector()
		{
			Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "RemotingSurrogateSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr);
			RemotingSurrogateSelector.NativeFieldInfoPtr_s_cachedTypeObjRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "s_cachedTypeObjRef");
			RemotingSurrogateSelector.NativeFieldInfoPtr__objRefSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "_objRefSurrogate");
			RemotingSurrogateSelector.NativeFieldInfoPtr__objRemotingSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "_objRemotingSurrogate");
			RemotingSurrogateSelector.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, "_next");
			RemotingSurrogateSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, 100672778);
			RemotingSurrogateSelector.NativeMethodInfoPtr_GetSurrogate_Public_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr, 100672779);
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x0012CF88 File Offset: 0x0012B188
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemotingSurrogateSelector()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemotingSurrogateSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotingSurrogateSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x0012CFC4 File Offset: 0x0012B1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355748, XrefRangeEnd = 355754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemotingSurrogateSelector.NativeMethodInfoPtr_GetSurrogate_Public_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			ssout = ((intPtr4 == 0) ? null : new ISurrogateSelector(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr5) : null;
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00018ACB File Offset: 0x00016CCB
		public RemotingSurrogateSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06004106 RID: 16646 RVA: 0x0012D05C File Offset: 0x0012B25C
		// (set) Token: 0x06004107 RID: 16647 RVA: 0x00018AD4 File Offset: 0x00016CD4
		public unsafe static Type s_cachedTypeObjRef
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingSurrogateSelector.NativeFieldInfoPtr_s_cachedTypeObjRef, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingSurrogateSelector.NativeFieldInfoPtr_s_cachedTypeObjRef, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06004108 RID: 16648 RVA: 0x0012D084 File Offset: 0x0012B284
		// (set) Token: 0x06004109 RID: 16649 RVA: 0x00018AE6 File Offset: 0x00016CE6
		public unsafe static ObjRefSurrogate _objRefSurrogate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRefSurrogate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjRefSurrogate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRefSurrogate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x0600410A RID: 16650 RVA: 0x0012D0AC File Offset: 0x0012B2AC
		// (set) Token: 0x0600410B RID: 16651 RVA: 0x00018AF8 File Offset: 0x00016CF8
		public unsafe static RemotingSurrogate _objRemotingSurrogate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRemotingSurrogate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemotingSurrogate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RemotingSurrogateSelector.NativeFieldInfoPtr__objRemotingSurrogate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x0600410C RID: 16652 RVA: 0x0012D0D4 File Offset: 0x0012B2D4
		// (set) Token: 0x0600410D RID: 16653 RVA: 0x00018B0A File Offset: 0x00016D0A
		public unsafe ISurrogateSelector _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingSurrogateSelector.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemotingSurrogateSelector.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003525 RID: 13605
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedTypeObjRef;

		// Token: 0x04003526 RID: 13606
		private static readonly IntPtr NativeFieldInfoPtr__objRefSurrogate;

		// Token: 0x04003527 RID: 13607
		private static readonly IntPtr NativeFieldInfoPtr__objRemotingSurrogate;

		// Token: 0x04003528 RID: 13608
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x04003529 RID: 13609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400352A RID: 13610
		private static readonly IntPtr NativeMethodInfoPtr_GetSurrogate_Public_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0;
	}
}
