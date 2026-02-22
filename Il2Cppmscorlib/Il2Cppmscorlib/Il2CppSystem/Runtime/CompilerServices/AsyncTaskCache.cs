using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000417 RID: 1047
	public static class AsyncTaskCache : Object
	{
		// Token: 0x060041B2 RID: 16818 RVA: 0x0012F6D0 File Offset: 0x0012D8D0
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncTaskCache()
		{
			Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncTaskCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr);
			AsyncTaskCache.NativeFieldInfoPtr_TrueTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "TrueTask");
			AsyncTaskCache.NativeFieldInfoPtr_FalseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "FalseTask");
			AsyncTaskCache.NativeFieldInfoPtr_Int32Tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "Int32Tasks");
			AsyncTaskCache.NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, 100672854);
			AsyncTaskCache.NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, 100672855);
		}

		// Token: 0x060041B3 RID: 16819 RVA: 0x0012F764 File Offset: 0x0012D964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356634, XrefRangeEnd = 356645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Task<int>> CreateInt32Tasks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskCache.NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Task<int>>>(intPtr3) : null;
		}

		// Token: 0x060041B4 RID: 16820 RVA: 0x0012F798 File Offset: 0x0012D998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356645, XrefRangeEnd = 356647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> CreateCacheableTask<TResult>(TResult result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskCache.MethodInfoStoreGeneric_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr4) : null;
			}
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x00019007 File Offset: 0x00017207
		public AsyncTaskCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x060041B6 RID: 16822 RVA: 0x0012F814 File Offset: 0x0012DA14
		// (set) Token: 0x060041B7 RID: 16823 RVA: 0x00019010 File Offset: 0x00017210
		public unsafe static Task<bool> TrueTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskCache.NativeFieldInfoPtr_TrueTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskCache.NativeFieldInfoPtr_TrueTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x060041B8 RID: 16824 RVA: 0x0012F83C File Offset: 0x0012DA3C
		// (set) Token: 0x060041B9 RID: 16825 RVA: 0x00019022 File Offset: 0x00017222
		public unsafe static Task<bool> FalseTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskCache.NativeFieldInfoPtr_FalseTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskCache.NativeFieldInfoPtr_FalseTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x060041BA RID: 16826 RVA: 0x0012F864 File Offset: 0x0012DA64
		// (set) Token: 0x060041BB RID: 16827 RVA: 0x00019034 File Offset: 0x00017234
		public unsafe static Il2CppReferenceArray<Task<int>> Int32Tasks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskCache.NativeFieldInfoPtr_Int32Tasks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Task<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskCache.NativeFieldInfoPtr_Int32Tasks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400359A RID: 13722
		private static readonly IntPtr NativeFieldInfoPtr_TrueTask;

		// Token: 0x0400359B RID: 13723
		private static readonly IntPtr NativeFieldInfoPtr_FalseTask;

		// Token: 0x0400359C RID: 13724
		private static readonly IntPtr NativeFieldInfoPtr_Int32Tasks;

		// Token: 0x0400359D RID: 13725
		private static readonly IntPtr NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0;

		// Token: 0x0400359E RID: 13726
		private static readonly IntPtr NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0;

		// Token: 0x02000639 RID: 1593
		private sealed class MethodInfoStoreGeneric_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0<TResult>
		{
			// Token: 0x04004402 RID: 17410
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskCache.NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0, Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
