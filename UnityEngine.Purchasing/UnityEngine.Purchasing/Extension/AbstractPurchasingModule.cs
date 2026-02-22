using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x0200001F RID: 31
	public class AbstractPurchasingModule : Object
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00006FAC File Offset: 0x000051AC
		// Note: this type is marked as 'beforefieldinit'.
		static AbstractPurchasingModule()
		{
			Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing.Extension", "AbstractPurchasingModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr);
			AbstractPurchasingModule.NativeFieldInfoPtr_m_Binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr, "m_Binder");
			AbstractPurchasingModule.NativeMethodInfoPtr_Configure_Public_Virtual_Final_New_Void_IPurchasingBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr, 100663446);
			AbstractPurchasingModule.NativeMethodInfoPtr_RegisterStore_Protected_Void_String_IStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr, 100663447);
			AbstractPurchasingModule.NativeMethodInfoPtr_BindExtension_Protected_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr, 100663448);
			AbstractPurchasingModule.NativeMethodInfoPtr_BindConfiguration_Protected_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr, 100663449);
			AbstractPurchasingModule.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr, 100663450);
			AbstractPurchasingModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr, 100663451);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00007068 File Offset: 0x00005268
		[CallerCount(0)]
		public unsafe virtual void Configure(IPurchasingBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractPurchasingModule.NativeMethodInfoPtr_Configure_Public_Virtual_Final_New_Void_IPurchasingBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000070AC File Offset: 0x000052AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131320, RefRangeEnd = 131321, XrefRangeStart = 131317, XrefRangeEnd = 131320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterStore(string name, IStore store)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(store);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractPurchasingModule.NativeMethodInfoPtr_RegisterStore_Protected_Void_String_IStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00007100 File Offset: 0x00005300
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 131323, RefRangeEnd = 131347, XrefRangeStart = 131321, XrefRangeEnd = 131323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindExtension<T>(T instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instance;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbstractPurchasingModule.MethodInfoStoreGeneric_BindExtension_Protected_Void_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00007178 File Offset: 0x00005378
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 131323, RefRangeEnd = 131347, XrefRangeStart = 131323, XrefRangeEnd = 131347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindConfiguration<T>(T instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = instance;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref instance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AbstractPurchasingModule.MethodInfoStoreGeneric_BindConfiguration_Protected_Void_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000071F0 File Offset: 0x000053F0
		[CallerCount(0)]
		public unsafe virtual void Configure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractPurchasingModule.NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000722C File Offset: 0x0000542C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbstractPurchasingModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractPurchasingModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000282A File Offset: 0x00000A2A
		public AbstractPurchasingModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00007268 File Offset: 0x00005468
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002833 File Offset: 0x00000A33
		public unsafe IPurchasingBinder m_Binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractPurchasingModule.NativeFieldInfoPtr_m_Binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPurchasingBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractPurchasingModule.NativeFieldInfoPtr_m_Binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr_m_Binder;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Final_New_Void_IPurchasingBinder_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_RegisterStore_Protected_Void_String_IStore_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_BindExtension_Protected_Void_T_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_BindConfiguration_Protected_Void_T_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000032 RID: 50
		private sealed class MethodInfoStoreGeneric_BindExtension_Protected_Void_T_0<T>
		{
			// Token: 0x0400011F RID: 287
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbstractPurchasingModule.NativeMethodInfoPtr_BindExtension_Protected_Void_T_0, Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000033 RID: 51
		private sealed class MethodInfoStoreGeneric_BindConfiguration_Protected_Void_T_0<T>
		{
			// Token: 0x04000120 RID: 288
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AbstractPurchasingModule.NativeMethodInfoPtr_BindConfiguration_Protected_Void_T_0, Il2CppClassPointerStore<AbstractPurchasingModule>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
